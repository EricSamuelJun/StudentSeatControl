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

        private Size seatControlSize;
        private Size studentControlSize;
        private Size showFinalControlSize;

        public List<StudentTable> students { get { return studentControl?.StudentBans; } }
        public List<Seat> seats { get { return seatControl?.seats; } }
        private readonly int DEFAULT_MAIN_ADD_SIZE = 200;
        private readonly int DEFAULT_PANEL_WIDTH = 650;
        public MainForm() {
            InitializeComponent();

            seatControl = new SeatControl();
            studentControl = new StudentControl();
            showFinalControl = new ShowFinalControl();

            // Store original designer sizes
            seatControlSize = seatControl.Size;
            studentControlSize = studentControl.Size;
            showFinalControlSize = showFinalControl.Size;
        }
        private void setContentPanel(Control content) {
            if(contentPanel.Controls.Count == 1 && contentPanel.Controls[0] == content) {
                contentPanel.Controls.Clear();
                this.ClientSize = new Size(DEFAULT_MAIN_ADD_SIZE + DEFAULT_PANEL_WIDTH, 700);
            } else {
                contentPanel.Controls.Clear();

                Size targetSize;
                if (content == seatControl) targetSize = seatControlSize;
                else if (content == studentControl) targetSize = studentControlSize;
                else if (content == showFinalControl) targetSize = showFinalControlSize;
                else targetSize = content.Size;

                // Set form size based on content size + sidebar width
                // Clientsize handles the internal area, ignoring borders and title bar
                this.ClientSize = new Size(DEFAULT_MAIN_ADD_SIZE + targetSize.Width, targetSize.Height + 50); // 50 for top(30)/bottom(20) padding
                
                content.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(content);

                if(content == showFinalControl) 
                    showFinalControl.OnFormCalled(students, seats);
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
