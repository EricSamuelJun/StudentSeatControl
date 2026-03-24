using System;
using System.Collections.Generic;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Repositories;
using TeacherSeatSetter.Services;

namespace TeacherSeatSetter.MVP.Presenters {
    internal sealed class StudentManagementPresenter {
        private readonly IStudentManagementView _view;
        private readonly IStudentRepository _repository;
        private readonly IStudentExcelService _excelService;
        private readonly List<StudentTable> _students = new List<StudentTable>();

        public StudentManagementPresenter(IStudentManagementView view, IStudentRepository repository, IStudentExcelService excelService) {
            _view = view;
            _repository = repository;
            _excelService = excelService;
        }

        public List<StudentTable> StudentClasses => _students;

        public void Initialize() {
            _students.Clear();
            _students.AddRange(_repository.Load());
            _view.BindClassList(_students);
            _view.BindStudentList(null);
        }

        public void Save() {
            _repository.Save(_students);
        }

        public void OnClassSelected(StudentTable studentTable) {
            _view.BindStudentList(studentTable?.students);
        }

        public void OnDeleteClass(StudentTable studentTable) {
            if (studentTable == null) {
                return;
            }

            _students.Remove(studentTable);
            _view.BindClassList(_students);
            _view.BindStudentList(null);
        }

        public void OnCreateSampleExcelRequested() {
            string path = _view.RequestSampleSavePath("class_sample.xlsx");
            if (string.IsNullOrWhiteSpace(path)) {
                return;
            }

            try {
                _view.ShowBusy(true);
                _excelService.CreateSampleWorkbook(path);
                _view.ShowInfo("저장되었습니다.");
            } catch (Exception ex) {
                _view.ShowError("오류\n" + ex.Message);
            } finally {
                _view.ShowBusy(false);
            }
        }

        public void OnCreateClass(string className) {
            if (string.IsNullOrWhiteSpace(className)) {
                _view.ShowError("반 이름을 입력해주세요.");
                return;
            }
            if (_students.Exists(s => s.cName == className.Trim())) {
                _view.ShowError("이미 같은 이름의 반이 존재합니다.");
                return;
            }
            var newClass = new StudentTable(className.Trim());
            _students.Add(newClass);
            _view.BindClassList(_students);
            _view.SelectClass(newClass);
            _view.BindStudentList(newClass.students);
        }

        public void OnAddStudent(StudentTable currentClass, string name, string numberStr) {
            if (currentClass == null) {
                _view.ShowError("먼저 반을 선택해주세요.");
                return;
            }
            if (string.IsNullOrWhiteSpace(name)) {
                _view.ShowError("학생 이름을 입력해주세요.");
                return;
            }
            int num;
            if (!int.TryParse(numberStr, out num)) {
                _view.ShowError("번호는 숫자로 입력해주세요.");
                return;
            }
            currentClass.AddRow(num, name, currentClass.cName);
            _view.BindStudentList(currentClass.students);
        }

        public void OnEditStudent(StudentTable currentClass, Student student, string newName, string newNumberStr) {
            if (student == null) {
                _view.ShowError("수정할 학생을 선택해주세요.");
                return;
            }
            if (string.IsNullOrWhiteSpace(newName)) {
                _view.ShowError("학생 이름을 입력해주세요.");
                return;
            }
            int num;
            if (!int.TryParse(newNumberStr, out num)) {
                _view.ShowError("번호는 숫자로 입력해주세요.");
                return;
            }
            student.name = newName;
            student.schoolNumber = num;
            _view.BindStudentList(currentClass?.students);
        }

        public void OnDeleteStudent(StudentTable currentClass, Student student) {
            if (student == null || currentClass == null) return;
            currentClass.students.Remove(student);
            _view.BindStudentList(currentClass.students);
        }

        public void OnImportExcelRequested() {
            string path = _view.RequestImportFilePath();
            if (string.IsNullOrWhiteSpace(path)) {
                return;
            }

            try {
                _view.ShowBusy(true);
                StudentImportResult result = _excelService.ImportWorkbook(path);
                if (result.Table != null) {
                    _students.Add(result.Table);
                    _view.BindClassList(_students);
                }
                _view.ShowInfo(string.Format("가져온 학생: {0}명\n오류: {1}건", result.ImportedCount, result.ErrorCount));
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            } finally {
                _view.ShowBusy(false);
            }
        }
    }
}
