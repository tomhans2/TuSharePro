using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuSharePro_Net;
using TuSharePro_Net.Models;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreApi api = new CoreApi("7e93ee7b3ee24dcb47197b655836658b754895d282b033de63a9535e");
            Dictionary<string, string> param = new Dictionary<string, string>
            {
                { "is_hs","H" }
            };
            string[] fields = { "a", "b", "c" };
            _BaseResponse content = api.RequestAsync(API_NAME.STOCK_BASIC, null, null).Result;
            Console.WriteLine(content.msg);
            Console.WriteLine(content.code);
            Console.WriteLine(content.request_id);
            Console.WriteLine(content.data.items.Count());
            Console.WriteLine(JsonConvert.SerializeObject(content,Formatting.Indented));
            Console.ReadLine();
        }
    }
}
