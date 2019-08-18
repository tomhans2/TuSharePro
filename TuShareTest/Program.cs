using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuSharePro;
using TuSharePro.Utils;

namespace TuShareTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreApi api = new CoreApi("6850350080b70c101eca3c9cfc0fe5c15c9daae4f69d8f0679a3d00e");
            // 请求数据（请求参数类型为string,非必选参数可为null/""），转DataTable，并输出结果
            Utility.PrintDataTable(api.stock_basic("", null, "", "ts_code,symbol,name,area,industry,fullname,enname,market,exchange,curr_type,list_status,list_date,delist_date,is_hs").Result.ToDataTable());
            Console.ReadKey();
        }
    }
}
