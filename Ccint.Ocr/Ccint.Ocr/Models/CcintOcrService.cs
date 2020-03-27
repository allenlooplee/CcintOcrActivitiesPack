using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ccint.Ocr.Models
{
    public class CcintOcrService
    {
        public CcintOcrService(string appKey, string appSecret)
        {
            _appKey = appKey;
            _appSecret = appSecret;
            _recognizerUrlLookup = GetRecognizerUrlLookup();
        }

        public async Task<JObject> RecognizeAsync(string recognizerName, string imagePath)
        {
            var recognizerUrl = _recognizerUrlLookup[recognizerName];
            var imageData = File.ReadAllBytes(imagePath);

            using (var client = new WebClient())
            {
                client.Headers.Add("app-key", _appKey);
                client.Headers.Add("app-secret", _appSecret);

                var response = await client.UploadDataTaskAsync(recognizerUrl, imageData);
                var result = Encoding.UTF8.GetString(response);

                return JObject.Parse(result);
            }
        }

        private Dictionary<string, string> GetRecognizerUrlLookup()
        {
            return new Dictionary<string, string>
            {
                [RecognizerNames.VatInvoice] = "https://ocr-api.ccint.com/cci_ai/service/v1/vat_invoice"
            };
        }

        private string _appKey;
        private string _appSecret;
        private Dictionary<string, string> _recognizerUrlLookup;
    }
}
