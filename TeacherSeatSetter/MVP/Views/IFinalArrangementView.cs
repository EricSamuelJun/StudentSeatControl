using System.Collections.Generic;
using TeacherSeatSetter.MVP.Models;

namespace TeacherSeatSetter.MVP.Views {
    internal interface IFinalArrangementView {
        void BindClasses(IEnumerable<StudentTable> students);
        void BindSeats(IEnumerable<Objects.Seat> seats);
        void RenderLayout(IReadOnlyList<SeatRenderItem> items);
        void ClearLayout();
        void ShowInfo(string message);
    }
}
