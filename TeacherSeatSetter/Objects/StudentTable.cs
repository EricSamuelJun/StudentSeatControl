using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace TeacherSeatSetter {
    public class StudentTable {
        public string cName;
        //public System.Data.DataTable dataTable;
        public List<Student> students { get; private set; }
        public int count { get => students == null ? 0 : students.Count; }
        public Student this[int index] {
            get {
                try {
                    return students[index];
                } catch (ArgumentOutOfRangeException) {
                    return null;
                }
                return students[index];
            }
        }
        
        public StudentTable(string name = "이름없는 반") {
            //dataTable = new System.Data.DataTable();
            //dataTable.Columns.Add("name", typeof(string));
            //dataTable.Columns.Add("number", typeof(int));
            //dataTable.Columns.Add("className", typeof(string));
            //dataTable.Columns.Add("seatNumber", typeof(int));

            students = new List<Student>();
            //DataColumn dc = new DataColumn();
            
            this.cName = name;
        }
        public void AddRow(Student stu) {
            /*System.Data.DataRow mdr = dataTable.NewRow();
            dr["name"] = (dr.IsNull("name") ? "오류" : dr["name"]);
            dr["number"] = (dr.IsNull("number") ? 0 : dr["number"]);
            dr["className"] = (dr.IsNull("className") ? "궭" : dr["className"]);
            dr["seatNumber"] = (dr.IsNull("seatNumber") ? 0 : dr["seatNumber"]);
            dataTable.Rows.Add(mdr);*/
            students.Add(stu);
        }
        public void AddRow(int number, string name, string className, int seatNumber = 0) {
            students.Add(new Student(name, number, seatNumber, className));
        }
        public void getFromSave(JObject saveObject) {
            /*
            JArray jarray = saveObject["Students"];
            foreach(JObject jobject in jarray) {
                
            }*/
        }
        public override string ToString() {
            return this.cName;
        }
    }
    public class Student {

        public string name { get; set; }
        public int schoolNumber { get; set; }
        public int seatNumber { get; set; }
        public string className { get; set; }
        public Student(string name, int schoolNumber, int seatNumber, string classname) {
            this.name = name;
            this.schoolNumber = schoolNumber;
            this.seatNumber = seatNumber;
            this.className = classname;
        }
        public void Swap(Student student) {
            int tempindex = this.seatNumber;
            this.seatNumber = student.seatNumber;
            student.seatNumber = tempindex;
        }
    }
}
