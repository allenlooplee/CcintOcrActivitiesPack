using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ccint.Ocr.Contracts
{
    public interface IOcrClient
    {
        string Name { get; }

        Task<JObject> RecognizeAsync(string recognizerName, string imagePath, Dictionary<string, object> options = null);
    }
}