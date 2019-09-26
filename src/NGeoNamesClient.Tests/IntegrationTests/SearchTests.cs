using System.Linq;
using System.Threading.Tasks;
using DutchAndBold.NGeoNamesClient.Dtos;
using DutchAndBold.NGeoNamesClient.Entities;
using DutchAndBold.NGeoNamesClient.Refit;
using Refit;
using Xunit;

namespace DutchAndBold.NGeoNamesClient.Tests.IntegrationTests
{
    public class SearchTests
    {
        [Fact]
        public async Task ItCanQueryACountry()
        {
            var client = RestService.For<IGeoNamesApi>(
                "http://api.geonames.org",
                new RefitSettings
                {
                    HttpMessageHandlerFactory = () => new GeoNamesHttpClientHandler("demo"),
                });

            var result = await client.Search(new SearchQuery()
            {
                Query = "United Kingdom",
                FeatureClass = "A",
                MaxRows = 1,
                Style = "FULL"
            });
            
            Assert.Single(result.GeoNames);
            Assert.Equal("GB", result.GeoNames.First().CountryCode);
        }
    }
}