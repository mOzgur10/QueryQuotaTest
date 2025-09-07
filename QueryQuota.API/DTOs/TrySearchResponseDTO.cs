using QueryQuota.Application.DTOs;


namespace QueryQuota.API.DTOs
{
    public class TrySearchResponseDTO
    {
        public IEnumerable<MyDataDTO>? Items { get; set; }
       
    }
}
