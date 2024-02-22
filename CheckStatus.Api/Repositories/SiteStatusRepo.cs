using CheckStatus.Api.Data;
using CheckStatus.Api.Entities;
using CheckStatus.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CheckStatus.Api.Repositories
{
    
    public class SiteStatusRepo : ISiteStatusRepo
    {
        private readonly CheckStatusDbContext checkStatusDbContext;

        public SiteStatusRepo(CheckStatusDbContext checkStatusDbContext)
        {
            this.checkStatusDbContext = checkStatusDbContext;   
        }
        public async Task<IEnumerable<SiteStatus>> GetStatus()
        {
            var checkStatus = await this.checkStatusDbContext.SiteStatuses.ToListAsync();

            return checkStatus; 
        }
    }
}
