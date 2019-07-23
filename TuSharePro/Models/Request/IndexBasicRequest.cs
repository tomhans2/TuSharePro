using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class IndexBasicRequest:_BaseRequest
    {
        public string market { get; set; }
        public string publisher { get; set; }
        public string category { get; set; }
    }
}
