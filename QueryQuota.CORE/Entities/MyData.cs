using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.CORE.Enums;

namespace QueryQuota.CORE.Entities
{
    public class MyData : IBaseEntity
    {
        public string Data { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString(); 
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

        public Status Status { get; set; } = Status.Created;
    }
}
