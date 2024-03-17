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

        public ShowFinalControl() {
            InitializeComponent();
            FormInit();
        }
        public void FormInit() {
            
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
    }
}
