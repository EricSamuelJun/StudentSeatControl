using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeacherSeatSetter.Forms;
using TeacherSeatSetter.MVP.Presenters;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Repositories;
using TeacherSeatSetter.Services;

namespace TeacherSeatSetter {
    public partial class StudentControl : UserControl, IStudentManagementView {
        private readonly StudentManagementPresenter _presenter;
        private Forms.WaitModal waitmodal;
        private Form busyOwnerForm;

        public List<StudentTable> StudentBans => _presenter.StudentClasses;
        public int count => StudentBans == null ? 0 : StudentBans.Count;

        public StudentControl() {
            InitializeComponent();
            _presenter = new StudentManagementPresenter(this, new EncryptedStudentRepository(), new StudentExcelClosedXmlService());
            FormInit();
        }

        public void FormInit() {
            grdStudentList.AutoGenerateColumns = false;
            grdStudentList.Columns.Clear();
            grdStudentList.Columns.Add(new DataGridViewColumn {
                DataPropertyName = "schoolNumber",
                HeaderText = "번호",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            grdStudentList.Columns.Add(new DataGridViewColumn {
                DataPropertyName = "name",
                HeaderText = "이름",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            grdStudentList.Columns.Add(new DataGridViewColumn {
                DataPropertyName = "className",
                HeaderText = "반",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            grdStudentList.Columns.Add(new DataGridViewColumn {
                DataPropertyName = "seatNumber",
                HeaderText = "좌석",
                Visible = false,
                CellTemplate = new DataGridViewTextBoxCell()
            });
            grdStudentList.AllowUserToAddRows = false;

            _presenter.Initialize();
        }

        private void whenExcelSampleDownloadClicked(object sender, EventArgs e) {
            _presenter.OnCreateSampleExcelRequested();
        }

        private void whenExcelUploadClicked(object sender, EventArgs e) {
            _presenter.OnImportExcelRequested();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            _presenter.OnDeleteClass(comboClass.SelectedItem as StudentTable);
        }

        private void comboClass_SelectionChangeCommitted(object sender, EventArgs e) {
            _presenter.OnClassSelected(comboClass.SelectedItem as StudentTable);
        }

        private void btnAddStudent_Click(object sender, EventArgs e) {
            _presenter.OnAddStudent(comboClass.SelectedItem as StudentTable, txtStudentName.Text, txtStudentNumber.Text);
            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
        }

        private void btnEditStudent_Click(object sender, EventArgs e) {
            Student selected = GetSelectedStudent();
            _presenter.OnEditStudent(comboClass.SelectedItem as StudentTable, selected, txtStudentName.Text, txtStudentNumber.Text);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e) {
            Student selected = GetSelectedStudent();
            _presenter.OnDeleteStudent(comboClass.SelectedItem as StudentTable, selected);
        }

        private void btnCreateClass_Click(object sender, EventArgs e) {
            _presenter.OnCreateClass(txtClassName.Text);
            txtClassName.Text = "";
        }

        private Student GetSelectedStudent() {
            if (grdStudentList.SelectedRows.Count == 0) return null;
            return grdStudentList.SelectedRows[0].DataBoundItem as Student;
        }

        private void grdStudentList_SelectionChanged(object sender, EventArgs e) {
            Student selected = GetSelectedStudent();
            if (selected != null) {
                txtStudentName.Text = selected.name;
                txtStudentNumber.Text = selected.schoolNumber.ToString();
            }
        }

        protected override void OnHandleDestroyed(EventArgs e) {
            _presenter.Save();
            base.OnHandleDestroyed(e);
        }

        public void BindClassList(IEnumerable<StudentTable> classes) {
            comboClass.Items.Clear();
            if (classes == null) {
                return;
            }

            foreach (StudentTable student in classes) {
                comboClass.Items.Add(student);
            }
        }

        public void BindStudentList(IEnumerable<Student> students) {
            grdStudentList.DataSource = null;
            grdStudentList.DataSource = students == null ? null : new List<Student>(students);
        }

        public void ShowInfo(string message) {
            MessageBox.Show(message);
        }

        public void ShowError(string message, string title = "오류") {
            MessageBox.Show(message, title);
        }

        public string RequestSampleSavePath(string defaultFileName) {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                dialog.Title = "저장 위치 선택";
                dialog.OverwritePrompt = true;
                dialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.FileName = defaultFileName;
                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
            }
        }

        public string RequestImportFilePath() {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Title = "가져올 파일 선택";
                dialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
            }
        }

        public void SelectClass(StudentTable studentTable) {
            if (studentTable == null) return;
            comboClass.SelectedItem = studentTable;
            _presenter.OnClassSelected(studentTable);
        }

        public void ShowBusy(bool isBusy) {
            if (isBusy) {
                if (waitmodal != null) {
                    return;
                }

                busyOwnerForm = this.FindForm() ?? Form.ActiveForm;
                waitmodal = new Forms.WaitModal();
                if (busyOwnerForm != null && !busyOwnerForm.IsDisposed) {
                    busyOwnerForm.Opacity = 0.50;
                }
                if (busyOwnerForm != null && !busyOwnerForm.IsDisposed) {
                    waitmodal.Show(busyOwnerForm);
                } else {
                    waitmodal.Show();
                }
                return;
            }

            if (waitmodal == null) {
                if (busyOwnerForm != null && !busyOwnerForm.IsDisposed) {
                    busyOwnerForm.Opacity = 1.0;
                }
                busyOwnerForm = null;
                return;
            }

            waitmodal.Close();
            waitmodal.Dispose();
            waitmodal = null;
            if (busyOwnerForm != null && !busyOwnerForm.IsDisposed) {
                busyOwnerForm.Opacity = 1.0;
            }
            busyOwnerForm = null;
        }
    }
}
