using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Cloud.Translation.V2;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleLearn
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            //   C:\Users\nurid\Desktop\ru.json
            string path = Console.ReadLine();
            string language = Console.ReadLine();


            string jsonText = File.ReadAllText(path);
            var jToken = JToken.Parse(jsonText);

            await UpdateDataService.ReplaceAndTranslateAsync(jToken, language);


            using (StreamWriter writer = new StreamWriter(@"C:\Users\nurid\Desktop\uz.json"))
            {
               await writer.WriteAsync(jToken.ToString());
            }
        }

    }
}
