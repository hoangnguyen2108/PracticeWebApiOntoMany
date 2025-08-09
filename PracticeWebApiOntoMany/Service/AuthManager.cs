using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PracticeWebApiOntoMany.Model.User;
using PracticeWebApiOntoMany.User;

namespace PracticeWebApiOntoMany.Service
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<ApiUser> _userManager;

        public AuthManager(UserManager<ApiUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<bool> Register(UserDto userDto)
        {
            var product = new ApiUser
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.EmailAddress,
                UserName = userDto.EmailAddress
            };
            var result = await _userManager.CreateAsync(product, userDto.PassWord);
            if (result.Succeeded)
            {
                var update = await _userManager.AddToRoleAsync(product, "User");
                return true;
            }
            return false;
        }

        [HttpPost]
        public async Task<bool> Login(UserLoginDto userLoginDto)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDto.Email);

            if (user == null)
            {
                return false;
            }
            var password = await _userManager.CheckPasswordAsync(user, userLoginDto.PassWord);

            if (password)
            {
                return true;
            }
            return false;
        }
    }
}
