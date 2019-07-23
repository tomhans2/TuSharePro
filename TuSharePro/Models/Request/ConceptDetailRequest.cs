using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class ConceptDetailRequest : _BaseRequest
    {
        public string id { get; set; }
        public string ts_code { get; set; }
    }
}
