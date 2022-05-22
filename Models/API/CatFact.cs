using Newtonsoft.Json;

namespace NichDevDotNetCore.Models
{
    [Serializable]
    public class CatFact
    {
        //[JsonProperty("title")]
        public string fact { get; set; }
        public int length { get; set; }
    }
}
