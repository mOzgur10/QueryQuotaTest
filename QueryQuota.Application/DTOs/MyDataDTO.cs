using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryQuota.CORE.Enums;

namespace QueryQuota.Application.DTOs
{
    public class MyDataDTO : IBaseDTO
    {
        public string Data { get; set; }
        public string Id { get; set; } 
        public DateTime CreatedAtUtc { get; set; }

        public Status Status { get; set; }
    }
}
