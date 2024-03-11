using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace TeacherSeatSetter {
    public class StudentTable : System.Data.DataTable {
        public string cName;
        public StudentTable(string name = "이름없는 반") {
            this.Columns.Add("name", typeof(string));
            this.Columns.Add("number", typeof(int));
            this.Columns.Add("className", typeof(string));
            this.Columns.Add("seatNumber", typeof(int));
            this.cName = name;
            PrintTypeForTest();
        }

        public void PrintTypeForTest() {
            Console.WriteLine("");
            foreach(System.Data.DataColumn col in this.Columns) {
                Console.WriteLine(""+col.ColumnName+" type is "+col.DataType.ToString());
            }
        }
        public void AddRow(System.Data.DataRow dr) {
            System.Data.DataRow mdr = this.NewRow();
            dr["name"] = (dr.IsNull("name") ? "오류" : dr["name"]);
            dr["number"] = (dr.IsNull("number") ? 0 : dr["number"]);
            dr["className"] = (dr.IsNull("className") ? "궭" : dr["className"]);
            dr["seatNumber"] = (dr.IsNull("seatNumber") ? 0 : dr["seatNumber"]);
            this.Rows.Add(mdr);

        }
        public void AddRow(int number, string name, string className, int seatNumber = 0) {
            System.Data.DataRow dr = this.NewRow();
            
            dr["name"] = name;
            dr["number"] = number;
            dr["className"] = className;
            dr["seatNumber"] = seatNumber;
            this.Rows.Add(dr);
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
}
