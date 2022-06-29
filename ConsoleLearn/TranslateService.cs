using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearn
{
    public class TranslateService
    {
        public static async Task<string> Translate(string str, string language)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://translo.p.rapidapi.com/api/v3/translate"),
                Headers =
                        {
                            { "X-RapidAPI-Key", "5e3e7f82c3msh4dba80873580ce0p19c1b1jsn0e9d7a6f2a8d" },
                            { "X-RapidAPI-Host", "translo.p.rapidapi.com" },
                        },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                        {
                            { "to", language },
                            { "text", str },
                        }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject obj = JObject.Parse(body);
                string name = (string)obj["translated_text"];
                return name;
            }
        }
    }
}
