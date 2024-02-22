using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStatus.Models.Dtos
{
    public class SiteStatusDto
    {
        public int Id { get; set; }
        public required string SiteName { get; set; }
        public required string IpAddress { get; set; }
        public bool IsOnline { get; set; }
    }
}
