using PracticeWebApiOntoMany.Model.User;

namespace PracticeWebApiOntoMany.Service
{
    public interface IAuthManager
    {
        Task<bool> Login(UserLoginDto userLoginDto);
        Task<bool> Register(UserDto userDto);
    }
}