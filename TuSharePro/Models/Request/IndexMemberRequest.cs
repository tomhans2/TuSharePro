using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class IndexMemberRequest:_BaseRequest
    {
        public string index_code { get; set; }
        public string ts_code { get; set; }
        public string is_new { get; set; }
    }
}
