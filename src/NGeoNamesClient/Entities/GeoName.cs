using Newtonsoft.Json;

namespace DutchAndBold.NGeoNamesClient.Entities
{
    public class GeoName
    {
        [JsonProperty("timezone")]
        public Timezone Timezone { get; set; }

        [JsonProperty("asciiName")]
        public string AsciiName { get; set; }

        [JsonProperty("astergdem")]
        public int Astergdem { get; set; }

        [JsonProperty("countryId")]
        public int CountryId { get; set; }

        [JsonProperty("fcl")]
        public FeatureClass FeatureClass { get; set; }

        [JsonProperty("srtm3")]
        public int Srtm3 { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("adminId2")]
        public int AdminId2 { get; set; }

        [JsonProperty("adminId3")]
        public int AdminId3 { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("adminCodes1")]
        public AdminCodes1 AdminCodes1 { get; set; }

        [JsonProperty("adminId1")]
        public int AdminId1 { get; set; }

        [JsonProperty("lat")]
        public string Latitude { get; set; }

        [JsonProperty("fcode")]
        public FeatureCode FeatureCode { get; set; }

        [JsonProperty("continentCode")]
        public string ContinentCode { get; set; }

        [JsonProperty("adminCode2")]
        public string AdminCode2 { get; set; }

        [JsonProperty("adminCode3")]
        public string AdminCode3 { get; set; }

        [JsonProperty("adminCode1")]
        public string AdminCode1 { get; set; }

        [JsonProperty("lng")]
        public string Longitude { get; set; }

        [JsonProperty("geonameId")]
        public int GeonameId { get; set; }

        [JsonProperty("toponymName")]
        public string ToponymName { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("adminName5")]
        public string AdminName5 { get; set; }

        [JsonProperty("adminName4")]
        public string AdminName4 { get; set; }

        [JsonProperty("adminName3")]
        public string AdminName3 { get; set; }

        [JsonProperty("alternateNames")]
        public AlternateName[] AlternateNames { get; set; }

        [JsonProperty("adminName2")]
        public string AdminName2 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fclName")]
        public string FeatureClassName { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("fcodeName")]
        public string FeatureCodeName { get; set; }

        [JsonProperty("adminName1")]
        public string AdminName1 { get; set; }
    }
}