using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json.Linq;
namespace TeacherSeatSetter {
    public class StudentTable {
        public string cName;
        public System.Data.DataTable dataTable;
        public System.Data.DataRow this[int index] {
            get {
                return dataTable.Rows[index];
            }
        }
        
        public StudentTable(string name = "이름없는 반") {
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("number", typeof(int));
            dataTable.Columns.Add("className", typeof(string));
            dataTable.Columns.Add("seatNumber", typeof(int));
            //DataColumn dc = new DataColumn();
            
            this.cName = name;
            PrintTypeForTest();
        }

        public void PrintTypeForTest() {
            Console.WriteLine("");
            foreach(System.Data.DataColumn col in dataTable.Columns) {
                Console.WriteLine(""+col.ColumnName+" type is "+col.DataType.ToString());
            }
        }
        public void AddRow(System.Data.DataRow dr) {
            System.Data.DataRow mdr = dataTable.NewRow();
            dr["name"] = (dr.IsNull("name") ? "오류" : dr["name"]);
            dr["number"] = (dr.IsNull("number") ? 0 : dr["number"]);
            dr["className"] = (dr.IsNull("className") ? "궭" : dr["className"]);
            dr["seatNumber"] = (dr.IsNull("seatNumber") ? 0 : dr["seatNumber"]);
            dataTable.Rows.Add(mdr);

        }
        public void AddRow(int number, string name, string className, int seatNumber = 0) {
            System.Data.DataRow dr = dataTable.NewRow();
            
            dr["name"] = name;
            dr["number"] = number;
            dr["className"] = className;
            dr["seatNumber"] = seatNumber;
            dataTable.Rows.Add(dr);
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
