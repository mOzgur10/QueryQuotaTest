using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QueryQuota.API.DTOs;
using QueryQuota.API.JwtFeatures;

using QueryQuota.CORE.Entities;

namespace QueryQuota.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtHandler _jwtHandler;

        public AccountController(UserManager<ApplicationUser> userManager, JwtHandler jwtHandler)
        {
            _userManager = userManager;
            _jwtHandler = jwtHandler;
        }

        [HttpPost("authentication")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDTO userForAuthentication)
        {
            var user = await _userManager.FindByNameAsync(userForAuthentication.Email!);
            if (user == null || !await _userManager.CheckPasswordAsync(user, userForAuthentication.Password!))
            {
                return Unauthorized(new AuthenticationResponseDTO { ErrorMessage = "Invalid Authentication" });
            }
            var token = _jwtHandler.CreateToken(user);

            return Ok(new AuthenticationResponseDTO { IsAuthenticationSuccessful = true, Token = token });
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserForRegistrationDTO userForRegistration)
        {
            if (string.IsNullOrWhiteSpace(userForRegistration.Email) || string.IsNullOrWhiteSpace(userForRegistration.Password))
                return BadRequest("Email ve şifre gereklidir.");

            var existingUser = await _userManager.FindByNameAsync(userForRegistration.Email!);
            if (existingUser != null)
                return BadRequest("Bu email ile zaten kayıtlı bir kullanıcı var.");

            var newUser = new ApplicationUser
            {
                UserName = userForRegistration.Email,
                Email = userForRegistration.Email
            };

            var result = await _userManager.CreateAsync(newUser, userForRegistration.Password!);

            if (!result.Succeeded)
            {
                var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                return BadRequest(errors);
            }

            return Ok("Kayıt başarılı.");
        }
    }
}

