using System.Collections.Generic;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Objects;
using TeacherSeatSetter.Services;

namespace TeacherSeatSetter.MVP.Presenters {
    internal sealed class FinalArrangementPresenter {
        private readonly IFinalArrangementView _view;
        private readonly ISeatArrangementService _arrangementService;

        private List<StudentTable> _students = new List<StudentTable>();
        private List<Seat> _seats = new List<Seat>();
        private StudentTable _selectedStudent;
        private Seat _selectedSeat;

        public FinalArrangementPresenter(IFinalArrangementView view, ISeatArrangementService arrangementService) {
            _view = view;
            _arrangementService = arrangementService;
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

        private void RenderIfReady() {
            if (_selectedSeat == null || _selectedStudent == null) {
                _view.ClearLayout();
                return;
            }

            if (_selectedSeat.Count == 0 || _selectedStudent.count == 0) {
                _view.ShowInfo("Invalid data.");
                _view.ClearLayout();
                return;
            }

            List<MVP.Models.SeatRenderItem> items = _arrangementService.BuildLayout(_selectedSeat, _selectedStudent, 30);
            if (_selectedSeat.Count > 30) {
                _view.ShowInfo("Seat count exceeds max render size (30). Rendering partial layout.");
            }
            _view.RenderLayout(items);
        }
    }
}
