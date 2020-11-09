using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBattlesSQLServer.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter an Email Address.")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
