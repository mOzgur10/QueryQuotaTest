using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.CORE.Enums;

namespace QueryQuota.CORE.Entities
{
    public class QueryLog : IBaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public string Term { get; set; }
        public DateTime CreatedAtUtc { get ; set ; }   = DateTime.UtcNow;
       
        public Status Status { get; set; } = Status.Created;
        public ApplicationUser User { get; set; }
    }
}
