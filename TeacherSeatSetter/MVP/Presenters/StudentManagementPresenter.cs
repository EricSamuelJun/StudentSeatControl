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
                _view.ShowInfo("Saved successfully.");
            } catch (Exception ex) {
                _view.ShowError("Error\n" + ex.Message);
            } finally {
                _view.ShowBusy(false);
            }
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
                _view.ShowInfo(string.Format("Imported rows: {0}\nRows with errors: {1}", result.ImportedCount, result.ErrorCount));
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            } finally {
                _view.ShowBusy(false);
            }
        }
    }
}
