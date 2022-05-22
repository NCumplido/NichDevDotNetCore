using Newtonsoft.Json;

namespace NichDevDotNetCore.Models.API
{
    [Serializable]
    public class CatFactResult
    {
        [JsonProperty("results")]
        public IEnumerable<CatFact> CatFacts { get; set; }
    }
}
