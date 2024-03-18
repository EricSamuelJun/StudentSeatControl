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
    public partial class Chair : UserControl {
        string name;
        public Chair(string name = "") {
            InitializeComponent();
            if (String.IsNullOrEmpty(name))
                name = string.Empty;
            else
                this.name = name;
        }
    }
}
