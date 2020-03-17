using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TuSharePro_Net.Models;

namespace TuSharePro_Net
{
    public class CoreApi
    {
        public string Token { get => _token;}
        private readonly string _token;
        private readonly string url = @"http://api.tushare.pro";
        private readonly HttpClient _httpClient;
        public CoreApi(string token)
        {
            this._token = token;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
            _httpClient.DefaultRequestHeaders.Clear();
        }
        public string SerializeRequest(API_NAME name, dynamic param=null, string[] fields=null)
        {
            dynamic request = new ExpandoObject();
            request.token = _token;
            request.api_name = name.ToString().ToLower();
            if(param != null)
            {
                request.@params = new Dictionary<string, string>();
                foreach (var property in (IDictionary<string, string>)param)
                {
                    request.@params.Add(property.Key, property.Value.ToString());
                }
            }
            if (fields != null)
            {
                request.fields = fields;
            }
            return JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
        public async Task<_BaseResponse> RequestAsync(API_NAME name, dynamic param=null, string[] fields = null)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                request.Content = new StringContent(SerializeRequest(name,param,fields));
                Console.WriteLine(SerializeRequest(name, param, fields));
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                request.Content.Headers.ContentType.CharSet = "utf-8";
                var response = await _httpClient.SendAsync(request);
                response.Content.Headers.ContentType.CharSet = "utf-8";
                response.EnsureSuccessStatusCode();
                var buffer = await response.Content.ReadAsByteArrayAsync();
                var byteArray = buffer.ToArray();
                var responseBody = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);

                return JsonConvert.DeserializeObject<_BaseResponse>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return new _BaseResponse
                {
                    request_id = "-1",
                    code = -1,
                    msg = "Exception Caught!",
                    data = null
                };
            }
        }
    }

    public enum API_NAME
    {
        STOCK_BASIC
    }
}
