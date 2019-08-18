using System;
using System.Data;

namespace TuSharePro.Utils
{
    public static class Utility
    {
        public static void PrintDataTable(DataTable dt)
        {
            foreach (DataColumn column in dt.Columns)
                Console.Write("\t{0}", column.ColumnName);
            Console.WriteLine("\t");

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", row[column]);

                Console.WriteLine("\t");

            }
        }

        public static string toJsonArray(string str)
        {
            string result = "";
            string[] strArray = str.Split(',');
            foreach (string field in strArray)
            {
                result = result + "\"" + field + "\"" + ",";
            }
            return "[" + result.Substring(0, result.Length - 1) + "]";
        }
    }
}
