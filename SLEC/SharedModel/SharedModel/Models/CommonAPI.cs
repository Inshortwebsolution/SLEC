using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharedModel.Models
{
    public class CommonAPI : ICommonAPI
    {

        public Response Get(string url)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) =>
            {
                return true;
            };
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string responseText = string.Empty;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) { responseText = streamReader.ReadToEnd(); }
            Response responseResult = JsonConvert.DeserializeObject<Response>(responseText);
            return responseResult;
        }
        public string ExtractBody(string html)
        {
            int bodyBegin = html.IndexOf("<body>") + "<body>".Length;
            int bodyEnd = html.IndexOf("</body>");
            int bodyLength = bodyEnd - bodyBegin;

            return html.Substring(bodyBegin, bodyLength);
        }
        public Response Post(string url, object data)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) =>
            {
                return true;
            };
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
            serializerSettings.Converters.Add(new DataTableConverter());
            string jsonString = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None, serializerSettings);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            { streamWriter.Write(jsonString); streamWriter.Flush(); streamWriter.Close(); }
            string responseText = string.Empty;
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) { responseText = streamReader.ReadToEnd(); }
            Response responseResult = JsonConvert.DeserializeObject<Response>(responseText);
            return responseResult;
        }

    }
}
