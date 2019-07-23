using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class IndexClassifyRequest : _BaseRequest
    {
        public string index_code { get; set; }
        public string level { get; set; }
        public string src { get; set; }
    }
}
