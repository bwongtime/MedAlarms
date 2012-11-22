using System;
//This is the login model that the loginController looks at to validate the login

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MedAlarms.Controllers
{
    public class LoginModel
    {
        [Required] //the email is required to login
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Required] //the password is required to login
        public string Password { get; set; }
    }
}
