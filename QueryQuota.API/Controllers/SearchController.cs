using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueryQuota.API.DTOs;

using QueryQuota.Application.Entities;
using QueryQuota.Application.Services.Exceptions;
using QueryQuota.Application.Services.IServices;

namespace QueryQuota.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
   
    public class SearchController : ControllerBase
    {
        
        private readonly IMyDataService _myDataService;
        private readonly IQuotaService _quotaService;

        public SearchController(IQuotaService quotaService, IMyDataService myDataService)
        {
            
            _myDataService = myDataService;
            _quotaService = quotaService;
        }


        [Authorize]
        [HttpGet("try")]
        public async Task<IActionResult> TrySearch([FromQuery] string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return BadRequest("Search term is required.");
            }

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            await _quotaService.TryConsumeAsync(userId, term, DateTime.UtcNow);//////
            var usage = await _quotaService.GetUsageAsync(userId, DateTime.UtcNow);

            var result = await _myDataService.GetFilteredListAsync(x => x.Data.Contains(term));
            if (result == null || !result.Any())
            {
                return NotFound("No matching data found.");
            }
            var response = new TrySearchResponseDTO
            {
                Items = result,//usage
                
            };

            return Ok(response);
            
        }

        [Authorize]
        [HttpGet("usage")]
        public async Task<IActionResult> GetUsage()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
                return Unauthorized("User ID not found.");

            var usage = await _quotaService.GetUsageAsync(userId, DateTime.UtcNow);

            return Ok(usage);
        }


    }
}
