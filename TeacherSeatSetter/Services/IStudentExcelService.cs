namespace TeacherSeatSetter.Services {
    internal interface IStudentExcelService {
        void CreateSampleWorkbook(string filePath);
        StudentImportResult ImportWorkbook(string filePath);
    }
}
