using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class OptBasicRequest : _BaseRequest
    {
        public string exchange { get; set; }
        public string call_put { get; set; }
    }
}
