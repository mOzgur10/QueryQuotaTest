using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QueryQuota.CORE.Enums;

namespace QueryQuota.CORE.Entities
{
    public interface IBaseEntity
    {
        public string Id { get; set; }
        DateTime CreatedAtUtc { get; set; }
        Status Status { get; set; }
    }
}
