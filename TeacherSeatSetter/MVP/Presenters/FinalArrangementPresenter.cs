using System;
using System.Collections.Generic;
using System.Linq;
using TeacherSeatSetter.MVP.Models;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Objects;
using TeacherSeatSetter.Repositories;
using TeacherSeatSetter.Services;

namespace TeacherSeatSetter.MVP.Presenters {
    internal sealed class FinalArrangementPresenter {
        private readonly IFinalArrangementView _view;
        private readonly ISeatArrangementService _arrangementService;
        private readonly IArrangementRepository _arrangementRepository;

        private List<StudentTable> _students = new List<StudentTable>();
        private List<Seat> _seats = new List<Seat>();
        private StudentTable _selectedStudent;
        private Seat _selectedSeat;
        private List<ArrangementRecord> _savedRecords;

        public FinalArrangementPresenter(IFinalArrangementView view, ISeatArrangementService arrangementService)
            : this(view, arrangementService, new EncryptedArrangementRepository()) {
        }

        public FinalArrangementPresenter(IFinalArrangementView view, ISeatArrangementService arrangementService, IArrangementRepository arrangementRepository) {
            _view = view;
            _arrangementService = arrangementService;
            _arrangementRepository = arrangementRepository;
            _savedRecords = _arrangementRepository.LoadAll();
        }

        public void SetSources(List<StudentTable> students, List<Seat> seats) {
            _students = students ?? new List<StudentTable>();
            _seats = seats ?? new List<Seat>();
            _selectedStudent = null;
            _selectedSeat = null;

            _view.BindClasses(_students);
            _view.BindSeats(_seats);
            _view.ClearLayout();
        }

        public void SelectClass(StudentTable studentTable) {
            _selectedStudent = studentTable;
            RenderIfReady();
        }

        public void SelectSeat(Seat seat) {
            _selectedSeat = seat;
            RenderIfReady();
        }

        public bool CanCapture() {
            return _selectedSeat != null && _selectedStudent != null;
        }

        public void RandomArrange() {
            if (_selectedSeat == null || _selectedStudent == null) {
                _view.ShowInfo("반과 교실을 먼저 선택해주세요.");
                return;
            }

            if (_selectedSeat.TotalStudents == 0 || _selectedStudent.count == 0) {
                _view.ShowInfo("유효하지 않은 데이터입니다.");
                return;
            }

            int excessStudents, emptySeats;
            List<MVP.Models.SeatRenderItem> items = _arrangementService.BuildRandomLayout(_selectedSeat, _selectedStudent, out excessStudents, out emptySeats);

            if (excessStudents > 0) {
                _view.ShowInfo("학생 수가 좌석 수보다 " + excessStudents + "명 많습니다.\n초과 학생은 배치되지 않았습니다.");
            }

            _view.RenderLayout(items, _selectedSeat);
        }

        public StudentTable SelectedStudentTable => _selectedStudent;

        public List<Student> GetUnassignedStudents(IReadOnlyList<MVP.Models.SeatRenderItem> renderedItems) {
            if (_selectedStudent == null) return new List<Student>();
            var assignedStudents = new HashSet<Student>(
                renderedItems.Where(item => item.Student != null).Select(item => item.Student)
            );
            return _selectedStudent.students
                .Where(s => !assignedStudents.Contains(s))
                .ToList();
        }

        public void SaveCurrentArrangement(IReadOnlyList<Forms.Chair> currentChairs) {
            if (_selectedSeat == null || _selectedStudent == null) {
                _view.ShowInfo("반과 교실을 먼저 선택해주세요.");
                return;
            }

            var record = new ArrangementRecord {
                ClassName = _selectedStudent.cName,
                SeatName = _selectedSeat.name,
                SavedAt = DateTime.Now,
                Mappings = new List<StudentSeatMapping>()
            };

            for (int i = 0; i < currentChairs.Count; i++) {
                var student = currentChairs[i].LinkedStudent;
                if (student != null) {
                    record.Mappings.Add(new StudentSeatMapping {
                        SeatIndex = i,
                        StudentName = student.name,
                        SchoolNumber = student.schoolNumber
                    });
                }
            }

            _savedRecords.Add(record);
            _arrangementRepository.Save(_savedRecords);
            _view.ShowInfo("배치가 저장되었습니다.");
        }

        public List<ArrangementRecord> GetSavedArrangements() {
            return _savedRecords;
        }

        public void LoadArrangement(ArrangementRecord record) {
            if (record == null || _selectedSeat == null || _selectedStudent == null) {
                _view.ShowInfo("반과 교실을 먼저 선택해주세요.");
                return;
            }

            var items = new List<SeatRenderItem>();
            int totalSlots = _selectedSeat.TotalStudents;
            for (int i = 0; i < totalSlots; i++) {
                var mapping = record.Mappings.FirstOrDefault(m => m.SeatIndex == i);
                Student student = null;
                if (mapping != null) {
                    student = _selectedStudent.students.FirstOrDefault(
                        s => s.schoolNumber == mapping.SchoolNumber && s.name == mapping.StudentName
                    );
                }
                items.Add(new SeatRenderItem {
                    Location = _selectedSeat.getStudentPosition(i),
                    Student = student
                });
            }

            _view.RenderLayout(items, _selectedSeat);
        }

        private void RenderIfReady() {
            if (_selectedSeat == null || _selectedStudent == null) {
                _view.ClearLayout();
                return;
            }

            if (_selectedSeat.TotalStudents == 0 || _selectedStudent.count == 0) {
                _view.ShowInfo("유효하지 않은 데이터입니다.");
                _view.ClearLayout();
                return;
            }

            List<MVP.Models.SeatRenderItem> items = _arrangementService.BuildLayout(_selectedSeat, _selectedStudent);
            _view.RenderLayout(items, _selectedSeat);
        }
    }
}
