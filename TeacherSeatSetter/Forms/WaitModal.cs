using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeacherSeatSetter.Forms {
    public partial class WaitModal : Form {
        public WaitModal(string title = "잠시만 기다려주세요", string mtext = "지금 작업 진행중입니다....") {
            InitializeComponent();
            this.Text = title;
            this.lblMessage.Text = mtext;
        }
    }
}
