namespace TeacherSeatSetter.Services {
    internal sealed class StudentImportResult {
        public StudentTable Table { get; set; }
        public int ImportedCount { get; set; }
        public int ErrorCount { get; set; }
    }
}
