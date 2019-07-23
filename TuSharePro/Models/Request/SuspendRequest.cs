using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class SuspendRequest:_BaseRequest
    {
        public string ts_code { get; set; }
        public string suspend_date { get; set; }
        public string resume_date { get; set; }

    }
}
