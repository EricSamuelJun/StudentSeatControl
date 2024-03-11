using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherSeatSetter.Forms {
    public partial class WaitModal : MetroFramework.Forms.MetroForm {
        public WaitModal(string title = "Wait for Second", string mtext = "지금 작업 진행중입니다....") {
            InitializeComponent();
            this.Text = title;
            this.metroLabel1.Text = mtext;
        }
        public void Stop() {

        }
    }
}
