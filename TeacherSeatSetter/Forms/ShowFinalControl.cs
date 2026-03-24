using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using TeacherSeatSetter.MVP.Models;
using TeacherSeatSetter.MVP.Presenters;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Objects;
using TeacherSeatSetter.Services;

namespace TeacherSeatSetter.Forms {
    public partial class ShowFinalControl : UserControl, IFinalArrangementView {
        private readonly List<Chair> chairs = new List<Chair>();
        private readonly FinalArrangementPresenter _presenter;
        private IReadOnlyList<SeatRenderItem> _lastRenderedItems;

        public ShowFinalControl() {
            InitializeComponent();
            _presenter = new FinalArrangementPresenter(this, new SeatArrangementService());
        }

        public void OnFormCalled(List<StudentTable> stutable, List<Seat> seats) {
            _presenter.SetSources(stutable, seats);
        }

        private void whenClassesListIndexChanged(object sender, EventArgs e) {
            if (lv_Classes.SelectedItems.Count <= 0) return;
            _presenter.SelectClass(lv_Classes.SelectedItems[0].Tag as StudentTable);
        }

        private void whenSeatListIndexChanged(object sender, EventArgs e) {
            if (lv_Seats.SelectedItems.Count <= 0) return;
            _presenter.SelectSeat(lv_Seats.SelectedItems[0].Tag as Seat);
        }

        private void btn_Random_Click(object sender, EventArgs e) {
            _presenter.RandomArrange();
        }

        private void btn_Capture_Click(object sender, EventArgs e) {
            CaptureAndSaveLayout();
        }

        private void CaptureAndSaveLayout() {
            if (!_presenter.CanCapture()) {
                MessageBox.Show("반과 교실을 먼저 선택해주세요.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "JPG files (*.jpg)|*.jpg";
                saveFileDialog.DefaultExt = "jpg";
                DateTime now = DateTime.Now;
                string className = lv_Classes.SelectedItems.Count > 0 ? lv_Classes.SelectedItems[0].Text : "반";
                string seatName = lv_Seats.SelectedItems.Count > 0 ? lv_Seats.SelectedItems[0].Text : "교실";
                string semester = (now.Month >= 8 || now.Month == 1) ? "2학기" : "1학기";
                string filename = now.Year + " " + semester + " " + className + " " + seatName + " 자리배치";
                saveFileDialog.FileName = filename + ".jpg";
                saveFileDialog.Title = "저장 위치 선택";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    using (Bitmap bmp = new Bitmap(contentPanel.Width, contentPanel.Height)) {
                        contentPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        MessageBox.Show("저장 완료: " + saveFileDialog.FileName);
                    }
                }
            }
        }

        public void BindClasses(IEnumerable<StudentTable> students) {
            lv_Classes.Clear();
            if (students == null) return;
            foreach (StudentTable student in students) {
                ListViewItem item = new ListViewItem { Text = student.cName, Tag = student };
                lv_Classes.Items.Add(item);
            }
        }

        public void BindSeats(IEnumerable<Seat> seats) {
            lv_Seats.Clear();
            if (seats == null) return;
            foreach (Seat seat in seats) {
                ListViewItem item = new ListViewItem { Text = seat.name, Tag = seat };
                lv_Seats.Items.Add(item);
            }
        }

        public void RenderLayout(IReadOnlyList<SeatRenderItem> items) {
            RenderLayout(items, null);
        }

        public void RenderLayout(IReadOnlyList<SeatRenderItem> items, Seat seat) {
            ClearLayout();
            if (items == null) return;

            _lastRenderedItems = items;

            // seatType에 따른 체어 크기 결정
            int chairW = 50, chairH = 50;
            if (seat != null) {
                chairW = seat.GetChairWidth();
                chairH = seat.GetChairHeight();
            }

            contentPanel.SuspendLayout();
            for (int i = 0; i < items.Count; i++) {
                Chair chair = new Chair();
                chair.Size = new Size(chairW, chairH);
                chair.Location = items[i].Location;
                chair.LinkStudent(items[i].Student);
                chair.StudentDroppedFromList += OnStudentDroppedFromList;
                chair.StudentSwapped += OnStudentSwapped;
                chairs.Add(chair);
                contentPanel.Controls.Add(chair);
            }
            contentPanel.ResumeLayout(true);

            UpdateUnassignedList();
        }

        public void ClearLayout() {
            contentPanel.SuspendLayout();
            foreach (Chair chair in chairs) {
                chair.StudentDroppedFromList -= OnStudentDroppedFromList;
                chair.StudentSwapped -= OnStudentSwapped;
                contentPanel.Controls.Remove(chair);
                chair.Dispose();
            }
            chairs.Clear();
            _lastRenderedItems = null;
            contentPanel.ResumeLayout(true);
            lstUnassigned.Items.Clear();
        }

        public void BindUnassignedStudents(IEnumerable<Student> students) {
            lstUnassigned.Items.Clear();
            if (students == null) return;
            foreach (Student s in students) {
                lstUnassigned.Items.Add(s);
            }
        }

        private void UpdateUnassignedList() {
            lstUnassigned.Items.Clear();
            if (_presenter.SelectedStudentTable == null) return;

            var assignedStudents = new HashSet<Student>(
                chairs.Where(c => c.LinkedStudent != null).Select(c => c.LinkedStudent)
            );

            foreach (Student s in _presenter.SelectedStudentTable.students) {
                if (!assignedStudents.Contains(s)) {
                    lstUnassigned.Items.Add(s);
                }
            }
        }

        private void OnStudentDroppedFromList(Chair chair, Student student) {
            UpdateUnassignedList();
        }

        private void OnStudentSwapped(Chair chair1, Chair chair2) {
            UpdateUnassignedList();
        }

        // Drag from unassigned list
        private void lstUnassigned_MouseDown(object sender, MouseEventArgs e) {
            if (lstUnassigned.SelectedItem == null) return;
            Student student = lstUnassigned.SelectedItem as Student;
            if (student == null) return;

            DragPayload payload = new DragPayload { Student = student, SourceChair = null };
            lstUnassigned.DoDragDrop(payload, DragDropEffects.Move);
        }

        // Drop back to unassigned list (from Chair)
        private void lstUnassigned_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(DragPayload))) {
                DragPayload payload = (DragPayload)e.Data.GetData(typeof(DragPayload));
                if (payload.SourceChair != null) {
                    e.Effect = DragDropEffects.Move;
                } else {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void lstUnassigned_DragDrop(object sender, DragEventArgs e) {
            if (!e.Data.GetDataPresent(typeof(DragPayload))) return;
            DragPayload payload = (DragPayload)e.Data.GetData(typeof(DragPayload));
            if (payload.SourceChair == null) return;

            payload.SourceChair.LinkStudent(null);
            UpdateUnassignedList();
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            _presenter.SaveCurrentArrangement(chairs.AsReadOnly());
        }

        private void btn_Load_Click(object sender, EventArgs e) {
            var records = _presenter.GetSavedArrangements();
            if (records == null || records.Count == 0) {
                MessageBox.Show("저장된 배치가 없습니다.");
                return;
            }

            using (Form dialog = new Form()) {
                dialog.Text = "배치 불러오기";
                dialog.Size = new Size(350, 400);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;

                ListBox lb = new ListBox();
                lb.Dock = DockStyle.Fill;
                lb.Font = new Font("맑은 고딕", 10F);
                foreach (var r in records) {
                    lb.Items.Add(r);
                }

                lb.DoubleClick += (s2, e2) => {
                    if (lb.SelectedItem != null) {
                        dialog.DialogResult = DialogResult.OK;
                        dialog.Close();
                    }
                };

                Button btnOk = new Button { Text = "선택", Dock = DockStyle.Bottom, Height = 35 };
                btnOk.Click += (s2, e2) => {
                    if (lb.SelectedItem != null) {
                        dialog.DialogResult = DialogResult.OK;
                        dialog.Close();
                    }
                };

                dialog.Controls.Add(lb);
                dialog.Controls.Add(btnOk);

                if (dialog.ShowDialog() == DialogResult.OK && lb.SelectedItem != null) {
                    _presenter.LoadArrangement(lb.SelectedItem as MVP.Models.ArrangementRecord);
                }
            }
        }

        public void ShowInfo(string message) {
            MessageBox.Show(message);
        }
    }
}
