using CheckStatus.Api.Repositories.Contracts;
using CheckStatus.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheckStatus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteStatusController : ControllerBase
    {
        private readonly ISiteStatusRepo siteStatusRepo;

        public SiteStatusController(ISiteStatusRepo siteStatusRepo) {
            this.siteStatusRepo = siteStatusRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SiteStatusDto>>> GetStatus()
        {
            try
            {
                var siteStatuses = await this.siteStatusRepo.GetStatus();

                if (siteStatuses == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(siteStatuses);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
