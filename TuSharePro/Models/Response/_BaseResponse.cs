using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Response
{
    public class _BaseResponse
    {
        public int code { get; set; }

        public string request_id { get; set; }

        public object msg { get; set; }

        public Data data { get; set; }

        
        public DataTable ToDataTable()
        {
            DataTable dt = new DataTable();
            if (this.code == 0) { 
                foreach (string field in this.data.fields)
                {
                    dt.Columns.Add(field);
                }
                foreach (List<object> obj in this.data.items)
                {
                    dt.Rows.Add(obj.ToArray());
                }
            }
            else
            {
                dt.Columns.Add("Code");
                dt.Columns.Add("Error");
                dt.Rows.Add(this.code,this.msg);
                
            }
            return dt;
        }

        public class Data
        {
            public List<string> fields { get; set; }
            public List<List<object>> items { get; set; }
        }
    }
}
