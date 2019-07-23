using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class FxObasicRequest : _BaseRequest
    {
        public string exchange { get; set; }
        public string classify { get; set; }
        public string ts_code { get; set; }
    }
}
