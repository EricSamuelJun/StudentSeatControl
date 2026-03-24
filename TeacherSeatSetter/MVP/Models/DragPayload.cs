using TeacherSeatSetter.Forms;

namespace TeacherSeatSetter.MVP.Models {
    internal sealed class DragPayload {
        public Student Student { get; set; }
        public Chair SourceChair { get; set; }
    }
}
