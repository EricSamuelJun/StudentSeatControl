using System.Collections.Generic;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.MVP.Views {
    internal interface ISeatManagementView {
        void BindSeatList(IEnumerable<Seat> seats);
        void UpdateSelectedSeat(Seat seat);
        void ShowInfo(string message);
        void ShowError(string message);
    }
}
