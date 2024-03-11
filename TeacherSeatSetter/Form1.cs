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

namespace TeacherSeatSetter {
    public partial class Form1 : MetroFramework.Forms.MetroForm {
        SeatControl seatControl;
        StudentControl studentControl;
        public List<StudentTable> sts { get { return studentControl?.students; } }
        public Form1() {
            InitializeComponent();

            seatControl = new SeatControl();
            studentControl = new StudentControl();
        }

        private void StudentControllClick(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(studentControl);
        }
    }
}
