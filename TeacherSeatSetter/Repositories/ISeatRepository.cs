using System.Collections.Generic;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Repositories {
    internal interface ISeatRepository {
        List<Seat> Load();
        void Save(List<Seat> seats);
    }
}
