using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.CORE.Enums;

namespace QueryQuota.Application.DTOs
{
    public class QueryLogDTO : IBaseDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Term { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
        public DateTime? DeletedAtUtc { get; set; }
        public Status Status { get; set; }
    }
}
