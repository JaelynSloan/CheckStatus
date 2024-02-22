using CheckStatus.Api.Entities;

namespace CheckStatus.Api.Repositories.Contracts
{
    public interface ISiteStatusRepo
    {
        Task<IEnumerable<SiteStatus>> GetStatus();
    }
}
