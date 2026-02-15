using System.Drawing;

namespace TeacherSeatSetter.MVP.Models {
    public sealed class SeatRenderItem {
        public Point Location { get; set; }
        public Student Student { get; set; }
    }
}
