using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace TeacherSeatSetter {
    class StudentTable : System.Data.DataTable {
        public string cName { get; private set; }
        public StudentTable(string name = "") {
            this.Columns.Add("name", typeof(int));
            this.Columns.Add("number", typeof(string));
            this.Columns.Add("className", typeof(string));
            this.Columns.Add("seatNumber", typeof(int));
            this.cName = name;
        }
        public void AddRow(System.Data.DataRow dr) {
            System.Data.DataRow mdr = this.NewRow();
            dr["name"] = (dr.IsNull("name") ? "" : dr["name"]);
            dr["number"] = (dr.IsNull("number") ? 0 : dr["number"]);
            dr["className"] = (dr.IsNull("className") ? "덕" : dr["className"]);
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
            JArray jarray = saveObject["Students"];
            foreach(JObject jobject in jarray) {
                
            }
        }

    }
}
