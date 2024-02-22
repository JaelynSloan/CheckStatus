using CheckStatus.Models.Dtos;
using CheckStatus.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.Data.Common;

namespace CheckStatus.Web.Pages
{
    public class SiteStatusBase:ComponentBase
    {
        [Inject]
        public ICheckStatusService CheckStatusService { get; set; }

        public IEnumerable<SiteStatusDto> SiteStatuses { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SiteStatuses = (IEnumerable<SiteStatusDto>)await CheckStatusService.GetStatus();
        }
    }
}
