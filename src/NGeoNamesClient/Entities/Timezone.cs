using Newtonsoft.Json;

namespace DutchAndBold.NGeoNamesClient.Entities
{
    public class Timezone
    {
        [JsonProperty("gmtOffset")]
        public int GmtOffset { get; set; }

        [JsonProperty("timeZoneId")]
        public string TimeZoneId { get; set; }

        [JsonProperty("dstOffset")]
        public int DstOffset { get; set; }
    }
}