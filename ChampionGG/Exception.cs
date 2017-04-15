using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChampionGG
{
    /// <summary>Deserialized server error response</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ErrorResponse
    {
        /// <summary>Server error message</summary>
        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; }
    }
    /// <summary>Exception of ChampionGG api</summary>
    public class Exception : System.Exception
    {
        /// <summary>HTTP status code</summary>
        public string StatusCode { get; private set; }
        /// <summary>Response data</summary>
        public byte[] ResponseData { get; private set; }

        /// <summary>Creates a ChampionGG Exception</summary>
        /// <param name="message"></param>
        /// <param name="statusCode"></param>
        /// <param name="responseData"></param>
        /// <param name="innerException"></param>
        public Exception(string message, string statusCode, byte[] responseData, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
            ResponseData = responseData;
        }
        /// <summary>Converts ChampionGG Exception to string</summary>
        /// <returns>HTTP Resonse</returns>
        public override string ToString()
        {
            return string.Format("HTTP Response: n{0}n{1}", Encoding.UTF8.GetString(ResponseData, 0, ResponseData.Length), base.ToString());
        }
    }
    /// <summary>Holds class of T</summary>
    /// <typeparam name="T"></typeparam>
    public class Exception<T> : Exception
    {
        /// <summary>Response</summary>
        public T Response { get; private set; }
        /// <summary>Creates a ChampionGG Exception containing exception</summary>
        /// <param name="message"></param>
        /// <param name="statusCode"></param>
        /// <param name="responseData"></param>
        /// <param name="response"></param>
        /// <param name="innerException"></param>
        public Exception(string message, string statusCode, byte[] responseData, T response, Exception innerException) : base(message, statusCode, responseData, innerException)
        {
            Response = response;
        }
    }
}
