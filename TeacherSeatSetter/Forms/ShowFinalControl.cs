using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public ShowFinalControl() {
            InitializeComponent();
            FormInit();
        }
        public void FormInit() {
            selectedSeat = null;
            selectedStudent = null;
            panelgraphic = panel1.CreateGraphics();
            panelgraphic.Clear(Color.White);
            //panelgraphic.DrawImage(Properties.Resources.seat_1, new Point(200,400));
            panelgraphic.DrawString("김아아", new System.Drawing.Font("넥슨Lv2고딕 Bold", 14F), new System.Drawing.SolidBrush(System.Drawing.Color.Black), new PointF(200, 400));
            //panelgraphic.DrawRectangle(new System.Drawing.Pen(Color.Black), new Rectangle(0, 0, 200, 300));
            panelgraphic.Dispose();
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

        }

        private void whenClassesListIndexChanged(object sender, EventArgs e) {

        }

        private void whenSeatListIndexChanged(object sender, EventArgs e) {

        }
        private void DrawScreen() {

        }
    }
}
