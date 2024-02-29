using MCorporation.Application.Services.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCorporation.API.Controllers.Corporation
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IAuthService _authService;

        public IdentityController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            var result = _authService.GenerateToken(login, password);
            return Ok(result.Result);
        }
    }
}
