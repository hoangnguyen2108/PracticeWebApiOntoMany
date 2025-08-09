using System.ComponentModel.DataAnnotations;

namespace PracticeWebApiOntoMany.Model.User
{
    public class UserLoginDto
    {
        [EmailAddress]
        public string Email { get; set; }

        public string PassWord { get; set; }
    }
}
