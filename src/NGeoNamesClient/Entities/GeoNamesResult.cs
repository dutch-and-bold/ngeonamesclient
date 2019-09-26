using System.Collections.Generic;

namespace DutchAndBold.NGeoNamesClient.Entities
{
    public class GeoNamesResult
    {
        public int TotalResultsCount { get; set; }

        public IEnumerable<GeoName> GeoNames { get; set; }
    }
}