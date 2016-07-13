using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace XDASv2Net.Tests.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson(this object value)
        {
            var settings = new JsonSerializerSettings
            {
                //ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
                //Converters = new List<JsonConverter> { new StringEnumConverter() }
            };

            return JsonConvert.SerializeObject(value, settings);
        }
    }
}
