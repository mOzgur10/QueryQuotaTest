using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryQuota.Application.Entities
{
    public class UsageInfo
    {
        public int DayUsed { get; set; }
        public int DayRemaining { get; set; }
        public int MonthUsed { get; set; }
        public int MonthRemaining { get; set; }
        public DateTime DayResetAtLocal { get; set; }
        public DateTime MonthResetAtLocal { get; set; }

    }
}
