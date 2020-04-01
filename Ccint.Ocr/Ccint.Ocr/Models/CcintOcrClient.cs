using Ccint.Ocr.Contracts;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ccint.Ocr.Models
{
    public class CcintOcrClient : IOcrClient
    {
        public CcintOcrClient(DataTable recognizerConfig)
        {
            Name = "Ccint OCR";
            _recognizerConfig = recognizerConfig;
        }

        public string Name { get; }

        public async Task<JObject> RecognizeAsync(string recognizerName, string imagePath, Dictionary<string, object> options = null)
        {
            if (!FindRecognizer(_recognizerConfig, recognizerName, out var recognizerUrl, out var appKey, out var appSecret))
            {
                throw new NotSupportedException($"{recognizerName} is not supported by {Name}.");
            }

            var imageData = File.ReadAllBytes(imagePath);

            using (var client = new WebClient())
            {
                client.Headers.Add("app-key", appKey);
                client.Headers.Add("app-secret", appSecret);

                var response = await client.UploadDataTaskAsync(recognizerUrl, imageData);
                var result = Encoding.UTF8.GetString(response);

                return JObject.Parse(result);
            }
        }

        private bool FindRecognizer(DataTable config, string recognizerName, out string recognizerUrl, out string appKey, out string appSecret)
        {
            var found = config.AsEnumerable().FirstOrDefault(row => row.Field<string>("RecognizerName") == recognizerName);
            if (found != null)
            {
                recognizerUrl = found.Field<string>("RecognizerUrl");
                appKey = found.Field<string>("AppKey");
                appSecret = found.Field<string>("AppSecret");

                return true;
            }
            else
            {
                recognizerUrl = null;
                appKey = null;
                appSecret = null;

                return false;
            }
        }

        private DataTable _recognizerConfig;
    }
}
