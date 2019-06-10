using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AtEase.Newtonsoft.Json.Test
{
    public class PersonConverter : JsonConverter<Person>
    {
        public override void WriteJson(JsonWriter writer, Person value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override Person ReadJson(JsonReader reader, Type objectType, Person existingValue, bool hasExistingValue,
                                        JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var firstName = jsonObject["FirstName"].Value<string>();
            var lastName = jsonObject["LastName"].Value<string>();
            return new Person(firstName +" "+lastName);
        }
    }
}