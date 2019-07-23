using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class NewsRequest : _BaseRequest
    {
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string src { get; set; }
    }
}
