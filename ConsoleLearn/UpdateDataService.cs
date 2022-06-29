using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearn
{
    public class UpdateDataService
    {
        public static async Task ReplaceAndTranslateAsync(JToken jtoken, string language)
        {
            if (!jtoken.Equals(null))
            {
                if (jtoken.Children().Any())
                {
                    foreach (var child in jtoken.Children())
                    {
                        await ReplaceAndTranslateAsync(child, language);
                        if (child.Type.Equals(JTokenType.Property))
                        {
                            var property = (JProperty)child;
                            if (!property.Value.HasValues)
                            {
                                property.Value = await TranslateService.Translate(property.Value.ToString(), language);
                            }
                        }
                    }
                }
            }
        }
    }
}
