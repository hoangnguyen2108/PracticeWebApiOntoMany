using System.ComponentModel.DataAnnotations;

namespace PracticeWebApiOntoMany.Model.User
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        public string PassWord { get; set; }

    }
}
