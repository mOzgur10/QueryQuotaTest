namespace QueryQuota.UI.DTOs
{
    public class UsageInfoDTO
    {
        public int DayUsed { get; set; }
        public int DayRemaining { get; set; }
        public int MonthUsed { get; set; }
        public int MonthRemaining { get; set; }
        public DateTime DayResetAtLocal { get; set; }
        public DateTime MonthResetAtLocal { get; set; }
    }
}
