using Newtonsoft.Json;

namespace DutchAndBold.NGeoNamesClient.Entities
{
    public class AlternateName
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string LanguageCode { get; set; }
    }
}