using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace TeacherSeatSetter {
    public partial class StudentControl : MetroFramework.Controls.MetroUserControl {
        public StudentControl() {
            InitializeComponent();
        }



        private void whenExcelSampleDownloadClicked(object sender, EventArgs e) {
            //액셀 셈플 다운로드 시작
        }

        private void whenExcelUploadClicked(object sender, EventArgs e) {
            //액셀 파일 업로드 시작
            Microsoft.Office.Interop.Excel.Application excelApplication = null;
            Workbook workbook = null;
            try {
                OpenFileDialog ofd = new OpenFileDialog();

            }catch(Exception ex) {

            } finally {

            }

        }
    }
}
