using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Forms {
    public partial class ShowFinalControl : MetroFramework.Controls.MetroUserControl {
        public List<StudentTable> students;
        public List<Seat> seats;
        private StudentTable selectedStudent;
        private Seat selectedSeat;
        private Graphics panelgraphic;
        private List<Chair> chairs = null;

        public ShowFinalControl() {
            InitializeComponent();
            FormInit();
        }
        public void FormInit() {
            chairs = new List<Chair>();
            selectedSeat = null;
            selectedStudent = null;


            //create chair object pool in chairs (max 30) (set visible false)
            for (int i = 0; i < 30; i++) {
                Chair chair = new Chair {
                    Visible = false,
                    Enabled = false,
                };
                this.chairs.Add(chair);
                this.contentPanel.Controls.Add(chair);
            }


        }
        public void OnFormCalled(List<StudentTable> stutable, List<Seat> seats) {
            this.students = stutable;
            this.seats = seats;
            lv_Classes.Clear();
            lv_Seats.Clear();
            foreach (Seat seat in seats) {
                ListViewItem item = new ListViewItem();
                item.Text = seat.name;
                item.Tag = seat;
                lv_Seats.Items.Add(item);
            }
            foreach (StudentTable student in students) {
                ListViewItem item = new ListViewItem();
                item.Text = student.cName;
                item.Tag = student;
                lv_Classes.Items.Add(item);
            }

        }



        private void whenClassesListIndexChanged(object sender, EventArgs e) {
            if (lv_Classes.SelectedItems.Count <= 0)
                return;
            selectedStudent = lv_Classes.SelectedItems[0].Tag as StudentTable;
            if (selectedStudent == null)
                return;
            DrawScreen();
        }

        private void whenSeatListIndexChanged(object sender, EventArgs e) {
            foreach(Chair chair in chairs) {
                chair.Visible = false;
                chair.Enabled = false;
            }
            if (lv_Seats.SelectedItems.Count <= 0)
                return;
            selectedSeat = lv_Seats.SelectedItems[0].Tag as Seat;
            if (selectedSeat == null)
                return;
            DrawScreen();
        }
        private void DrawScreen() {
            if (selectedSeat == null || selectedStudent == null) {
                return;
            }
            if (selectedSeat.Count == 0 || selectedStudent.count == 0) {
                MessageBox.Show("데이터가 잘못되었습니다.");
                return;
            }

            int seatRow = selectedSeat.rowCount;
            int seatColumn = selectedSeat.columnCount;

            int seatCount = selectedSeat.Count;


            //set chairs location seatRow count and seatCol count. Gap is 100 each. start X  = 155, Y = 420. X is increase. Y is decrease
            int startX = 155;
            int startY = 420;
            int gap = 100;

            for (int i = 0; i < seatCount; i++) {
                chairs[i].Visible = true;
                chairs[i].Enabled = true;
                int row = i / seatColumn;
                int col = i % seatColumn;

                int x = startX + col * gap;
                int y = startY - row * gap;

                chairs[i].Location = new Point(x, y);

                // Link selectedStudent with each chair
                chairs[i].LinkStudent(selectedStudent[i]);
            }
            contentPanel.Invalidate();

            //Done!

        }
















        private void btn_Capture_Click(object sender, EventArgs e) {
            CaptureAndSaveLayout();
        }

        private void CaptureAndSaveLayout() {
            if (selectedSeat == null || selectedStudent == null) {
                MessageBox.Show("반과 교실을 선택하여 주세요!");
                return;
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "JPG files (*.jpg)|*.jpg";
                saveFileDialog.DefaultExt = "jpg";
                DateTime now = DateTime.Now;

                string filename = now.Year.ToString() + "년 " + ((now.Month >= 8 || now.Month == 1) ? "2" : "1") + "학기 " + selectedStudent.cName + " " + selectedSeat.ToString() + "교실 반 배정표";
                saveFileDialog.FileName = filename + ".jpg";
                saveFileDialog.Title = "[파일 저장] " + filename + " 저장";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    using (Bitmap bmp = new Bitmap(contentPanel.Width, contentPanel.Height)) {
                        contentPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        MessageBox.Show(saveFileDialog.FileName + "로 저장하였습니다.");
                    }
                }
            }
        }
    }
}
