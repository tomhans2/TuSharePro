using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class GzIndexRequest : _BaseRequest
    {
        public string date { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }
}
