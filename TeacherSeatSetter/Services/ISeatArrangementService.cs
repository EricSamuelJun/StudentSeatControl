using System.Collections.Generic;
using TeacherSeatSetter.MVP.Models;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Services {
    internal interface ISeatArrangementService {
        List<SeatRenderItem> BuildLayout(Seat seat, StudentTable studentTable);
        List<SeatRenderItem> BuildRandomLayout(Seat seat, StudentTable studentTable, out int excessStudents, out int emptySeats);
    }
}
