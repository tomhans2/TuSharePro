using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class FutBasicRequest : _BaseRequest
    {
        public string exchange { get; set; }
        public string fut_type { get; set; }
    }
}
