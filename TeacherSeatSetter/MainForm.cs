using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherSeatSetter.Forms;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter {
    public partial class MainForm : MetroFramework.Forms.MetroForm {
        internal SeatControl seatControl;
        internal StudentControl studentControl;
        internal ShowFinalControl showFinalControl;
        public List<StudentTable> students { get { return studentControl?.students; } }
        public List<Seat> seats { get { return seatControl?.seats; } }
        public MainForm() {
            InitializeComponent();

            seatControl = new SeatControl();
            studentControl = new StudentControl();
            showFinalControl = new ShowFinalControl();
        }

        private void StudentControllClick(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(studentControl);
        }

        private void btnSeatOnClicked(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(seatControl);
        }

        private void btnShowOnClicked(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(showFinalControl);
            showFinalControl.OnFormCalled(students,seats);
        }
    }
}
