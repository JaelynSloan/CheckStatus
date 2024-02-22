using CheckStatus.Models.Dtos;
using CheckStatus.Web.Services.Contracts;
using System.Net.Http.Json;

namespace CheckStatus.Web.Services
{
    public class CheckStatusService : ICheckStatusService
    {
        private readonly HttpClient httpClient;

        public CheckStatusService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<SiteStatusDto>> GetStatus()
        {
            try
            {
                var siteStatuses = await this.httpClient.GetFromJsonAsync<IEnumerable<SiteStatusDto>>("api/SiteStatus");

                return siteStatuses;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
