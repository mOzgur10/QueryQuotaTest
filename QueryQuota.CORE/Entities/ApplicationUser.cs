using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace QueryQuota.CORE.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<QueryLog>? QueryLogs { get; set; }
    }
}
