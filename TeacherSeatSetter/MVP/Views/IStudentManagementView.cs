using System.Collections.Generic;

namespace TeacherSeatSetter.MVP.Views {
    internal interface IStudentManagementView {
        void BindClassList(IEnumerable<StudentTable> classes);
        void BindStudentList(IEnumerable<Student> students);
        void ShowInfo(string message);
        void ShowError(string message, string title = "Error");
        string RequestSampleSavePath(string defaultFileName);
        string RequestImportFilePath();
        void ShowBusy(bool isBusy);
    }
}
