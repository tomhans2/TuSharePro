using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class _BaseRequest
    {
        public string token { get; set; }
        public string api_name { get; set; }
        [JsonProperty(PropertyName = "params")]
        public Dictionary<string,string> paramsList {get; set;}
        public string[] fields { get; set; }

        public T Request<T>(string url, string jsonData)
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/json";
                req.Timeout = 10000;

                //发送内容
                using (Stream reqStream = req.GetRequestStream())
                {
                    var sendData = Encoding.UTF8.GetBytes(jsonData);
                    reqStream.Write(sendData, 0, sendData.Length);
                    reqStream.Close();
                }
                //获取内容
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex.GetType().FullName);
                Debug.WriteLine(ex.GetBaseException().ToString());
                //result = "{\"code\": \"-1\",\"request_id\":\"\",\"msg\":"+ex.GetBaseException().ToString()+ ",\"data\":\"\"}";
            }
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
