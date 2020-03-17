using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuSharePro_Net.Models
{
    public class _BaseResponse
    {
        public int code { get; set; }

        public string request_id { get; set; }

        public object msg { get; set; }

        public Data data { get; set; }

    }
    public class Data
    {
        public List<string> fields { get; set; }
        public List<List<object>> items { get; set; }
    }
}
