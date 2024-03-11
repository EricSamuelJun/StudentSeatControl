using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace TeacherSeatSetter {
    public partial class StudentControl : MetroFramework.Controls.MetroUserControl {
        DataSet dataSet = null;
        public StudentControl() {
            InitializeComponent();
            //
            FormInit();
        }
        public void FormInit() {
            //데이터 로드

            //데이터가 없다면 샘플 데이터 집어넣기
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("name", typeof(string)));
        }


        private void whenExcelSampleDownloadClicked(object sender, EventArgs e) {
            //액셀 셈플 다운로드 시작
            MessageBox.Show("테스트 중임");
        }

        private void whenExcelUploadClicked(object sender, EventArgs e) {
            //액셀 파일 업로드 시작
            Microsoft.Office.Interop.Excel.Application excelApplication = null;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            try {
                OpenFileDialog ofd = new OpenFileDialog();

            }catch(Exception ex) {

            } finally {

            }
            MessageBox.Show("테스트 중임");

        }
    }
}
