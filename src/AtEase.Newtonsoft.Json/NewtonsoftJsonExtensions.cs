using Newtonsoft.Json;

namespace AtEase.Newtonsoft.Json
{
    public static class NewtonsoftJsonExtensions
    {
        public static string ToJson(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static TDest To<TDest>(this string value)
        {
            return JsonConvert.DeserializeObject<TDest>(value);
        }
    }
}