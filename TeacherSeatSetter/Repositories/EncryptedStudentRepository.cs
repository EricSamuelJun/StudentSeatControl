using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TeacherSeatSetter.Objects;

namespace TeacherSeatSetter.Repositories {
    internal sealed class EncryptedStudentRepository : IStudentRepository {
        public List<StudentTable> Load() {
            var data = FileManagement.manager.LoadFile("students", true);
            if (data == null) {
                return new List<StudentTable>();
            }

            try {
                return JsonConvert.DeserializeObject<List<StudentTable>>((string)data) ?? new List<StudentTable>();
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Student load failed: " + ex.Message);
                return new List<StudentTable>();
            }
        }

        public void Save(List<StudentTable> students) {
            FileManagement.manager.SaveFile("students", students ?? new List<StudentTable>(), true);
        }
    }
}
