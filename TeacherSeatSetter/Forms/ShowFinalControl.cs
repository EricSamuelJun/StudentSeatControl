using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

        public ShowFinalControl() {
            InitializeComponent();
            _presenter = new FinalArrangementPresenter(this, new SeatArrangementService());
            FormInit();
        }

        public void FormInit() {
            for (int i = 0; i < 30; i++) {
                Chair chair = new Chair {
                    Visible = false,
                    Enabled = false
                };
                chairs.Add(chair);
                contentPanel.Controls.Add(chair);
            }
        }

        public void OnFormCalled(List<StudentTable> stutable, List<Seat> seats) {
            _presenter.SetSources(stutable, seats);
        }

        private void whenClassesListIndexChanged(object sender, EventArgs e) {
            if (lv_Classes.SelectedItems.Count <= 0) {
                return;
            }

            _presenter.SelectClass(lv_Classes.SelectedItems[0].Tag as StudentTable);
        }

        private void whenSeatListIndexChanged(object sender, EventArgs e) {
            if (lv_Seats.SelectedItems.Count <= 0) {
                return;
            }

            _presenter.SelectSeat(lv_Seats.SelectedItems[0].Tag as Seat);
        }

        private void btn_Capture_Click(object sender, EventArgs e) {
            CaptureAndSaveLayout();
        }

        private void CaptureAndSaveLayout() {
            if (!_presenter.CanCapture()) {
                MessageBox.Show("Select class and classroom first.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "JPG files (*.jpg)|*.jpg";
                saveFileDialog.DefaultExt = "jpg";
                DateTime now = DateTime.Now;
                string className = lv_Classes.SelectedItems.Count > 0 ? lv_Classes.SelectedItems[0].Text : "Class";
                string seatName = lv_Seats.SelectedItems.Count > 0 ? lv_Seats.SelectedItems[0].Text : "Room";
                string filename = now.Year + " " + ((now.Month >= 8 || now.Month == 1) ? "Semester2" : "Semester1") + " " + className + " " + seatName + " Seating";
                saveFileDialog.FileName = filename + ".jpg";
                saveFileDialog.Title = "Save " + filename;
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    using (Bitmap bmp = new Bitmap(contentPanel.Width, contentPanel.Height)) {
                        contentPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        MessageBox.Show("Saved to " + saveFileDialog.FileName);
                    }
                }
            }
        }

        public void BindClasses(IEnumerable<StudentTable> students) {
            lv_Classes.Clear();
            if (students == null) {
                return;
            }

            foreach (StudentTable student in students) {
                ListViewItem item = new ListViewItem {
                    Text = student.cName,
                    Tag = student
                };
                lv_Classes.Items.Add(item);
            }
        }

        public void BindSeats(IEnumerable<Seat> seats) {
            lv_Seats.Clear();
            if (seats == null) {
                return;
            }

            foreach (Seat seat in seats) {
                ListViewItem item = new ListViewItem {
                    Text = seat.name,
                    Tag = seat
                };
                lv_Seats.Items.Add(item);
            }
        }

        public void RenderLayout(IReadOnlyList<SeatRenderItem> items) {
            ClearLayout();
            if (items == null) {
                return;
            }

            int renderCount = Math.Min(items.Count, chairs.Count);
            for (int i = 0; i < renderCount; i++) {
                chairs[i].Visible = true;
                chairs[i].Enabled = true;
                chairs[i].Location = items[i].Location;
                chairs[i].LinkStudent(items[i].Student);
            }
            contentPanel.Invalidate();
        }

        public void ClearLayout() {
            foreach (Chair chair in chairs) {
                chair.Visible = false;
                chair.Enabled = false;
                chair.LinkStudent(null);
            }
            contentPanel.Invalidate();
        }

        public void ShowInfo(string message) {
            MessageBox.Show(message);
        }
    }
}
