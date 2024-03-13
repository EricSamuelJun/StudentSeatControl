using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using TeacherSeatSetter.Forms;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter {
    public partial class StudentControl : MetroFramework.Controls.MetroUserControl {
        public List<StudentTable> students = null;
        WaitModal waitmodal;
        bool isStop = false;
        public StudentControl() {
            InitializeComponent();
            //
            FormInit();
        }
        public void FormInit() {
            //데이터 로드
            var data =  FileManagement.manager.LoadFile("students",true);
            try {
                students = (data == null  ? new List<StudentTable>() : (Newtonsoft.Json.JsonConvert.DeserializeObject<List<StudentTable>>((string)data)));
            }catch(Exception ex) {
                Console.WriteLine("Exception: "+ex.Message+"\n"+ex.StackTrace);
                students = new List<StudentTable>();
            }

            Console.WriteLine("class Count: "+students.Count);

            grdStudentList.AutoGenerateColumns = false;
            reloadNameList();
        }
        public void reloadNameList() {
            comboClass.Items.Clear();   
            foreach(StudentTable student in students) {
                Console.WriteLine("className: "+student.cName);
                comboClass.Items.Add(student);
            }

            this.grdStudentList.DataSource = null;
        }

        private void whenExcelSampleDownloadClicked(object sender, EventArgs e) {
            //액셀 셈플 다운로드 시작
            MessageBox.Show("샘플 다운로드 시작");
            Excel.Application excelApplication = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            try {
                string fileName;
                string filePath;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                sfd.Title = "저장 위치 지정해주세요";
                sfd.OverwritePrompt = true;
                sfd.Filter = "엑셀 파일 (*.xlsx)|*.xlsx";
                sfd.DefaultExt = "xlsx";
                if (sfd.ShowDialog() == DialogResult.OK) {
                    fileName = sfd.FileName;
                    //filePath = sfd.file
                } else {
                    MessageBox.Show("저장을 취소합니다.");
                    return;
                }
                StopFormAndModal();
                excelApplication = new Excel.Application();
                workbook = excelApplication.Workbooks.Add();
                worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 3]].Merge();
                worksheet.Cells[1, 1] = "3 A 생활과 윤리";
                worksheet.Cells[2, 1] = "반";
                worksheet.Cells[2, 2] = "이름";
                worksheet.Cells[2, 3] = "학번";
                Excel.Range rg = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[2, 3]];
                rg.Font.Bold = true;
                rg.HorizontalAlignment = 3;
                worksheet.Range[worksheet.Cells[1, 2], worksheet.Cells[1, 3]].ColumnWidth = 30;
                worksheet.Cells[2, 1].ColumnWidth = 10;
                workbook.SaveAs(fileName);
                workbook.Close(true);
                excelApplication.Quit();
                ModalEnd();
                MessageBox.Show("저장이 완료되었습니다!");
            } catch (Exception ex) {
                MessageBox.Show("에러 발생\n" + ex.Message);
            } finally {
                ModalEnd();

            }
            reloadNameList();

        }

        private void whenExcelUploadClicked(object sender, EventArgs e) {
            //액셀 파일 업로드 시작
            Excel.Application excelApplication = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            try {
                string fileName;
                string filePath;

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "오픈 파일 위치 지정해주세요";
                ofd.Filter = "엑셀 파일 (*.xlsx)|*.xlsx";
                ofd.DefaultExt = "xlsx";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                if (ofd.ShowDialog() == DialogResult.OK) {
                    fileName = ofd.FileName;
                } else {
                    MessageBox.Show("업로드를 취소합니다.");
                    return;
                }
                StopFormAndModal();
                excelApplication = new Excel.Application();
                workbook = excelApplication.Workbooks.Open(fileName);
                worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;
                Excel.Range usedRange = worksheet.UsedRange;
                if(usedRange.Rows.Count <= 2) {
                    ModalEnd();
                    return;
                }
                string cName;
                cName = (string)(usedRange.Cells[1,1] as Excel.Range).Value2;
                StudentTable stuTable = new StudentTable(cName);
                int count = 0;
                int errorCnt = 0;
                for(int row=3; row <= usedRange.Rows.Count + 2; row++) {
                    string ban = string.Empty;
                    string name = string.Empty;
                    int number = 0;
                    bool isError = false;
                    
                    try {
                        ban = (string)(usedRange.Cells[row, 1] as Excel.Range).Value2;
                        name = (string)(usedRange.Cells[row, 2] as Excel.Range).Value2;
                        number = (int)(usedRange.Cells[row, 3] as Excel.Range).Value2;
                        count++;
                        stuTable.AddRow(Convert.ToInt16(number), name, ban,row-2);
                    }
                    catch(Exception ex) {
                        isError = true;
                        errorCnt++;
                        Console.WriteLine("Error on code StudentControl.cs line 145, Excel Row: "+row+"\n"+ex.Message + "\n\n\n"+ex.StackTrace+ "\n\n\n");
                    }
                    
                }
                ModalEnd();
                MessageBox.Show(String.Format("총 {0}개의 행을 불러왔습니다.\n에러 행은 {1}개 발생했습니다.", count, errorCnt));
                students.Add(stuTable);

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            } finally {
                workbook.Close(true);
                excelApplication.Quit();
                ModalEnd();

            }
            reloadNameList();

        }

        public void StopFormAndModal() {
            //if (!isStop)
            //    return;
            if (waitmodal != null)
                return;
            waitmodal = new WaitModal();
            
            Console.WriteLine("wait modal on");
            if (waitmodal.ContainsFocus) {
                Form.ActiveForm.Opacity = 0.50;
                waitmodal.Show();
            }
        }
        public void ModalEnd() {
            //if (!isStop)
            //    return;
            if (waitmodal == null)
                return;
            Console.WriteLine("wait modal off");
            waitmodal.Close();
            if (waitmodal.ContainsFocus) {
                Form.ActiveForm.Opacity = 1;
            }
        }
        //해당 combobox 삭제
        private void btnDelete_Click(object sender, EventArgs e) {
            StudentTable st = comboClass.SelectedItem as StudentTable;
            students.Remove(st);
            reloadNameList();
        }
        //콤보박스 새로고침
        private void comboClass_SelectionChangeCommitted(object sender, EventArgs e) {
            //바뀌면 grd 바꿔놓기
            this.grdStudentList.DataSource = (comboClass.SelectedItem as StudentTable).dataTable;
        }
        protected override void OnHandleDestroyed(EventArgs e) {
            if (students.Count == 0) {
                //return;
            }
            FileManagement.manager.SaveFile("students", students, true);
            base.OnHandleDestroyed(e);
        }
    }
}
