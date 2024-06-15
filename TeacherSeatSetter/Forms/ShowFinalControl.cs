using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Forms {
    public partial class ShowFinalControl : MetroFramework.Controls.MetroUserControl {
        public List<StudentTable> students;
        public List<Seat> seats;
        private StudentTable selectedStudent;
        private Seat selectedSeat;
        private Graphics panelgraphic;
        private List<Chair> chairs;

        public ShowFinalControl() {
            InitializeComponent();
            FormInit();
        }
        public void FormInit() {
            selectedSeat = null;
            selectedStudent = null;
            this.chair1.LabelText = "쯔위";
            this.chair2.LabelText = "고세구";
            this.chair3.LabelText = "냥뇽녕냥";
            
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
            foreach(StudentTable student in students) {
                ListViewItem item = new ListViewItem();
                item.Text = student.cName;
                item.Tag = student;
                lv_Classes.Items.Add(item);
            }

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
                
                string filename = now.Year.ToString()+"년 "+((now.Month >= 8 || now.Month == 1) ? "2" : "1")+"학기 "+selectedStudent.ToString() + " " + selectedSeat.ToString() + "교실 반 배정표";
                saveFileDialog.FileName = filename + ".jpg";
                saveFileDialog.Title = "[파일 저장] "+filename + " 저장";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    using (Bitmap bmp = new Bitmap(contentPanel.Width, contentPanel.Height)) {
                        contentPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        MessageBox.Show(saveFileDialog.FileName+"로 저장하였습니다.");
                    }
                }
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
            if (lv_Seats.SelectedItems.Count <= 0)
                return;
            selectedSeat = lv_Seats.SelectedItems[0].Tag as Seat;
            if (selectedSeat == null)
                return;
            DrawScreen();
        }
        private void DrawScreen() {
            if (selectedSeat == null ||  selectedStudent == null ) {
                return;
            }
            if(selectedSeat.Count == 0 || selectedStudent.dataTable.Rows.Count == 0) {
                MessageBox.Show("데이터가 잘못되었습니다.");
                return;
            }
            int row = selectedSeat.rowCount;
            int column = selectedSeat.columnCount;


        }
    }
}
