using System.Collections.Generic;
using TeacherSeatSetter.MVP.Views;
using TeacherSeatSetter.Objects;
using TeacherSeatSetter.Repositories;

namespace TeacherSeatSetter.MVP.Presenters {
    internal sealed class SeatManagementPresenter {
        private readonly ISeatManagementView _view;
        private readonly ISeatRepository _repository;
        private readonly List<Seat> _seats = new List<Seat>();
        private Seat _selectedSeat;

        public SeatManagementPresenter(ISeatManagementView view, ISeatRepository repository) {
            _view = view;
            _repository = repository;
        }

        public List<Seat> Seats => _seats;

        public void Initialize() {
            _seats.Clear();
            _seats.AddRange(_repository.Load());
            _selectedSeat = null;
            _view.BindSeatList(_seats);
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void Save() {
            _repository.Save(_seats);
        }

        public void SelectSeat(Seat seat) {
            _selectedSeat = seat;
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void CreateNewSeat() {
            _selectedSeat = new Seat();
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void DeleteSelectedSeat() {
            if (_selectedSeat == null) {
                return;
            }

            _seats.Remove(_selectedSeat);
            _selectedSeat = null;
            _view.BindSeatList(_seats);
            _view.UpdateSelectedSeat(null);
        }

        public void SaveSelectedSeat(string seatName) {
            if (string.IsNullOrWhiteSpace(seatName)) {
                _view.ShowError("Seat name is required.\nSave failed.");
                return;
            }

            if (_selectedSeat == null) {
                _view.ShowError("No seat selected.\nSave failed.");
                return;
            }

            _selectedSeat.name = seatName;
            if (!_seats.Contains(_selectedSeat)) {
                _seats.Add(_selectedSeat);
            }

            _view.BindSeatList(_seats);
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void IncreaseRow() {
            if (_selectedSeat == null || _selectedSeat.rowCount >= 6) {
                return;
            }

            _selectedSeat.rowCount++;
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void DecreaseRow() {
            if (_selectedSeat == null || _selectedSeat.rowCount <= 1) {
                return;
            }

            _selectedSeat.rowCount--;
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void IncreaseColumn() {
            if (_selectedSeat == null || _selectedSeat.columnCount >= 6) {
                return;
            }

            _selectedSeat.columnCount++;
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void DecreaseColumn() {
            if (_selectedSeat == null || _selectedSeat.columnCount <= 1) {
                return;
            }

            _selectedSeat.columnCount--;
            _view.UpdateSelectedSeat(_selectedSeat);
        }

        public void SetSeatTypeByIndex(int index) {
            if (_selectedSeat == null) {
                return;
            }

            switch (index) {
                case 0:
                    _selectedSeat.seatType = SeatType.OneSeat;
                    break;
                case 1:
                    _selectedSeat.seatType = SeatType.TwoSeat;
                    break;
                case 2:
                    _selectedSeat.seatType = SeatType.ThreeSeat;
                    break;
                default:
                    return;
            }

            _view.UpdateSelectedSeat(_selectedSeat);
        }
    }
}
