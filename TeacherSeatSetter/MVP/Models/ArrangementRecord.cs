using System;
using System.Collections.Generic;

namespace TeacherSeatSetter.MVP.Models {
    public sealed class ArrangementRecord {
        public string ClassName { get; set; }
        public string SeatName { get; set; }
        public DateTime SavedAt { get; set; }
        public List<StudentSeatMapping> Mappings { get; set; }

        public override string ToString() {
            return SavedAt.ToString("yy/MM/dd HH:mm") + " " + ClassName + " " + SeatName;
        }
    }

    public sealed class StudentSeatMapping {
        public int SeatIndex { get; set; }
        public string StudentName { get; set; }
        public int SchoolNumber { get; set; }
    }
}
