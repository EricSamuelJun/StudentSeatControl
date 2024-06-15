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
        private readonly int DEFAULT_MAIN_ADD_SIZE = 230;
        private readonly int DEFAULT_PANEL_WIDTH = 620;
        public MainForm() {
            InitializeComponent();

            seatControl = new SeatControl();
            studentControl = new StudentControl();
            showFinalControl = new ShowFinalControl();
        }
        private void setContentPanel(Control content) {
            if(contentPanel.Controls.Count == 1 && contentPanel.Controls[0] == content) {
                contentPanel.Controls.Clear();
                contentPanel.Width = DEFAULT_PANEL_WIDTH;
                this.Width = DEFAULT_MAIN_ADD_SIZE + DEFAULT_PANEL_WIDTH;
            } else {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(content);
                if(content == showFinalControl) 
                    showFinalControl.OnFormCalled(students, seats);
                contentPanel.Width = content.Width;
                this.Width = DEFAULT_MAIN_ADD_SIZE + content.Width;
            }
        }
        private void StudentControllClick(object sender, EventArgs e) {
            setContentPanel(studentControl);
        }

        private void btnSeatOnClicked(object sender, EventArgs e) {
            setContentPanel(seatControl);
        }

        private void btnShowOnClicked(object sender, EventArgs e) {
            setContentPanel(showFinalControl);
        }

        private void btnContact_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://open.kakao.com/me/game_dev");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
