using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeacherSeatSetter.Forms;
using TeacherSeatSetter.MVP.Presenters;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Repositories;
using TeacherSeatSetter.Services;

namespace TeacherSeatSetter {
    public partial class StudentControl : MetroFramework.Controls.MetroUserControl, IStudentManagementView {
        private readonly StudentManagementPresenter _presenter;
        private WaitModal waitmodal;
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
                HeaderText = "Number",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            grdStudentList.Columns.Add(new DataGridViewColumn {
                DataPropertyName = "name",
                HeaderText = "Name",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            grdStudentList.Columns.Add(new DataGridViewColumn {
                DataPropertyName = "className",
                HeaderText = "Class",
                CellTemplate = new DataGridViewTextBoxCell()
            });
            grdStudentList.Columns.Add(new DataGridViewColumn {
                DataPropertyName = "seatNumber",
                HeaderText = "Seat",
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

        protected override void OnHandleDestroyed(EventArgs e) {
            _presenter.Save();
            base.OnHandleDestroyed(e);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (comboClass.SelectedItem == null) {
                return;
            }

            foreach (Student stu in (comboClass.SelectedItem as StudentTable).students) {
                System.Diagnostics.Debug.WriteLine("{0} {3} {1} {2}", stu.name, stu.className, stu.seatNumber, stu.schoolNumber);
            }
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

        public void ShowError(string message, string title = "Error") {
            MessageBox.Show(message, title);
        }

        public string RequestSampleSavePath(string defaultFileName) {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                dialog.Title = "Choose save location";
                dialog.OverwritePrompt = true;
                dialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.FileName = defaultFileName;
                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
            }
        }

        public string RequestImportFilePath() {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Title = "Choose file to import";
                dialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                dialog.DefaultExt = "xlsx";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
            }
        }

        public void ShowBusy(bool isBusy) {
            if (isBusy) {
                if (waitmodal != null) {
                    return;
                }

                busyOwnerForm = this.FindForm() ?? Form.ActiveForm;
                waitmodal = new WaitModal();
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
