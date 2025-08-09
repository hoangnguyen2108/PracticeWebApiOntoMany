
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PracticeWebApiOntoMany.User
{
    public class ApiUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

 
    }
}
