using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PracticeWebApiOntoMany.Model.User;
using PracticeWebApiOntoMany.Service;
using PracticeWebApiOntoMany.User;
using System.Formats.Asn1;

namespace PracticeWebApiOntoMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthManager _authManager;
        private readonly UserManager<ApiUser> _userManager;

        public AccountController(IAuthManager authManager,UserManager<ApiUser> userManager)
        {
            _authManager = authManager;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("Register")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Register (UserDto userDto)
        {
            var result = await _authManager.Register(userDto);
            if (!result)
            {
                return BadRequest("Unsuccess");
            }
            return Ok("Success");
        }

        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Login (UserLoginDto userLoginDto)
        {
            var result = await _authManager.Login(userLoginDto);
            if (!result)
            {
                return BadRequest("Unsuccess");
            }
            return Ok("Success");
        }
    }
}
