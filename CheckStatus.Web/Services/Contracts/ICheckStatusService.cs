using CheckStatus.Models.Dtos;

namespace CheckStatus.Web.Services.Contracts
{
    public interface ICheckStatusService
    {
        Task<IEnumerable<SiteStatusDto>> GetStatus();

    }
}
