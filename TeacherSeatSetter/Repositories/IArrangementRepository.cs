using System.Collections.Generic;
using TeacherSeatSetter.MVP.Models;

namespace TeacherSeatSetter.Repositories {
    internal interface IArrangementRepository {
        List<ArrangementRecord> LoadAll();
        void Save(List<ArrangementRecord> records);
    }
}
