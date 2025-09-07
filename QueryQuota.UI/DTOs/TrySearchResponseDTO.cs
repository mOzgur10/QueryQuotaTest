namespace QueryQuota.UI.DTOs
{
    public class TrySearchResponseDTO
    {
        public IEnumerable<MyDataDTO>? Items { get; set; }
        public UsageInfoDTO? Usage { get; set; }
    }
}
