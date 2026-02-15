using System.Collections.Generic;

namespace TeacherSeatSetter.Repositories {
    internal interface IStudentRepository {
        List<StudentTable> Load();
        void Save(List<StudentTable> students);
    }
}
