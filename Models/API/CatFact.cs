using Newtonsoft.Json;

namespace NichDevDotNetCore.Models
{
    [Serializable]
    public class CatFact
    {
        //[JsonProperty("title")]
        public string Fact { get; set; }
        public int Length { get; set; }
    }
}
