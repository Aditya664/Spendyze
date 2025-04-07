using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Spendyze.DTOs;
using Spendyze.Repositories;

namespace Spendyze.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        
            private readonly UserManager<IdentityUser> userManager;
            private readonly ITokenRepository tokenRepository;
            public AccountController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
            {
                this.userManager = userManager;
                this.tokenRepository = tokenRepository;
            }

            [HttpPost]
            [Route("Register")]
            public async Task<IActionResult> Register([FromBody] RegisterDto registerRequestDto)
            {
                var idenitityUser = new IdentityUser
                {
                    UserName = registerRequestDto.Username,
                    Email = registerRequestDto.Email
                };
                var identityResult = await userManager.CreateAsync(idenitityUser, registerRequestDto.Password);
                if (identityResult.Succeeded)
                {
                    if (identityResult.Succeeded)
                    {
                        return Ok("User was registred! Please login");
                    }
                }
                return BadRequest();
            }

            [HttpPost]
            [Route("Login")]
            public async Task<IActionResult> Login([FromBody] LoginDto loginRequestDto)
            {
                var user = await userManager.FindByNameAsync(loginRequestDto.UserName);
                if (user != null)
                {
                    var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginRequestDto.Password);
                    if (checkPasswordResult)
                    {
                        var roles = await userManager.GetRolesAsync(user);
                        if (roles != null)
                        {
                            var jwtToken = tokenRepository.CreateJwtToken(user);
                            var loginResponse = new LoginResponseDto
                            {
                                JwtToken = jwtToken,
                            };
                            return Ok(loginResponse);
                        }
                    }
                }
                return BadRequest("Username or Password incorrect");
            }
     
    }
}
