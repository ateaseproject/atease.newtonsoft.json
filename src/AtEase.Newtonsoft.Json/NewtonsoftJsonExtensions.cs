using System.Diagnostics;
using Newtonsoft.Json;

namespace AtEase.Newtonsoft.Json
{
    public static class NewtonsoftJsonExtensions
    {
        /// <summary>
        ///     Serializes the specified object to a JSON string.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <returns>A JSON string representation of the object.</returns>
        [DebuggerStepThrough]
        public static string SerializeToJson(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        /// <summary>
        ///     Serializes the specified object to a JSON string using formatting.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <returns>A JSON string representation of the object.</returns>
        [DebuggerStepThrough]
        public static string SerializeToJson(this object value, Formatting formatting)
        {
            return JsonConvert.SerializeObject(value, formatting);
        }

        /// <summary>
        ///     Serializes the specified object to a JSON string using a collection of
        ///     <see cref="T:Newtonsoft.Json.JsonConverter" />.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="converters">A collection of converters used while serializing.</param>
        /// <returns>A JSON string representation of the object.</returns>
        [DebuggerStepThrough]
        public static string SerializeToJson(this object value, params JsonConverter[] converters)
        {
            return JsonConvert.SerializeObject(value, converters);
        }

        /// <summary>
        ///     Serializes the specified object to a JSON string using formatting and a collection of
        ///     <see cref="T:Newtonsoft.Json.JsonConverter" />.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <param name="converters">A collection of converters used while serializing.</param>
        /// <returns>A JSON string representation of the object.</returns>
        [DebuggerStepThrough]
        public static string SerializeToJson(this object value, Formatting formatting,
            params JsonConverter[] converters)
        {
            return JsonConvert.SerializeObject(value, formatting, converters);
        }

        /// <summary>
        ///     Serializes the specified object to a JSON string using <see cref="T:Newtonsoft.Json.JsonSerializerSettings" />.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="settings">
        ///     The <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> used to serialize the object.
        ///     If this is <c>null</c>, default serialization settings will be used.
        /// </param>
        /// <returns>A JSON string representation of the object.</returns>
        [DebuggerStepThrough]
        public static string SerializeToJson(this object value, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, settings);
        }

        /// <summary>
        ///     Serializes the specified object to a JSON string using formatting and
        ///     <see cref="T:Newtonsoft.Json.JsonSerializerSettings" />.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <param name="settings">
        ///     The <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> used to serialize the object.
        ///     If this is <c>null</c>, default serialization settings will be used.
        /// </param>
        /// <returns>A JSON string representation of the object.</returns>
        [DebuggerStepThrough]
        public static string SerializeToJson(this object value, Formatting formatting, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, formatting, settings);
        }


        /// <summary>
        ///     Deserializes the JSON to the specified .NET type.
        /// </summary>
        /// <typeparam name="TDest">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The JSON to deserialize.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        [DebuggerStepThrough]
        public static TDest DeserializeJsonAs<TDest>(this string value)
        {
            return JsonConvert.DeserializeObject<TDest>(value);
        }

        /// <summary>
        ///     Deserializes the JSON to the specified .NET type using a collection of
        ///     <see cref="T:Newtonsoft.Json.JsonConverter" />.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="converters">Converters to use while deserializing.</param>
        /// <returns>The deserialized object from the JSON string.</returns>
        [DebuggerStepThrough]
        public static T DeserializeJsonAs<T>(this string value, params JsonConverter[] converters)
        {
            return JsonConvert.DeserializeObject<T>(value, converters);
        }

        /// <summary>
        ///     Deserializes the JSON to the specified .NET type using <see cref="T:Newtonsoft.Json.JsonSerializerSettings" />.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The object to deserialize.</param>
        /// <param name="settings">
        ///     The <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> used to deserialize the object.
        ///     If this is <c>null</c>, default serialization settings will be used.
        /// </param>
        /// <returns>The deserialized object from the JSON string.</returns>
        [DebuggerStepThrough]
        public static T DeserializeJsonAs<T>(string value, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeObject<T>(value, settings);
        }
    }
}