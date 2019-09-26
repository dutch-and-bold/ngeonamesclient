using System.Threading.Tasks;
using DutchAndBold.NGeoNamesClient.Dtos;
using DutchAndBold.NGeoNamesClient.Entities;
using Refit;

namespace DutchAndBold.NGeoNamesClient
{
    public interface IGeoNamesApi
    {
        [Get("/searchJSON")]
        Task<GeoNamesResult> Search(SearchQuery query);
    }
}