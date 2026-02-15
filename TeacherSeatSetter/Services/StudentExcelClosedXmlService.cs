using System;
using ClosedXML.Excel;

namespace TeacherSeatSetter.Services {
    internal sealed class StudentExcelClosedXmlService : IStudentExcelService {
        public void CreateSampleWorkbook(string filePath) {
            using (XLWorkbook workbook = new XLWorkbook()) {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Sheet1");
                worksheet.Range(1, 1, 1, 3).Merge();
                worksheet.Cell(1, 1).Value = "Class Sample";
                worksheet.Cell(2, 1).Value = "Class";
                worksheet.Cell(2, 2).Value = "Name";
                worksheet.Cell(2, 3).Value = "Number";

                IXLRange headerRange = worksheet.Range(1, 1, 2, 3);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                worksheet.Column(1).Width = 12;
                worksheet.Column(2).Width = 28;
                worksheet.Column(3).Width = 12;

                workbook.SaveAs(filePath);
            }
        }

        public StudentImportResult ImportWorkbook(string filePath) {
            StudentImportResult result = new StudentImportResult {
                ImportedCount = 0,
                ErrorCount = 0,
                Table = null
            };

            using (XLWorkbook workbook = new XLWorkbook(filePath)) {
                IXLWorksheet worksheet = workbook.Worksheet(1);
                int lastRow = worksheet.LastRowUsed()?.RowNumber() ?? 0;
                if (lastRow <= 2) {
                    return result;
                }

                string className = worksheet.Cell(1, 1).GetString();
                StudentTable table = new StudentTable(className);

                for (int row = 3; row <= lastRow; row++) {
                    try {
                        string ban = worksheet.Cell(row, 1).GetString();
                        string name = worksheet.Cell(row, 2).GetString();
                        if (string.IsNullOrWhiteSpace(ban) || string.IsNullOrWhiteSpace(name)) {
                            continue;
                        }

                        if (!worksheet.Cell(row, 3).TryGetValue(out int number)) {
                            result.ErrorCount++;
                            continue;
                        }

                        table.AddRow(Convert.ToInt16(number), name, ban, row - 2);
                        result.ImportedCount++;
                    } catch {
                        result.ErrorCount++;
                    }
                }

                result.Table = table;
            }

            return result;
        }
    }
}
