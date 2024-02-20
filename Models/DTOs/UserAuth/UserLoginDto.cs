using System;
using System.ComponentModel.DataAnnotations;

namespace proiect_daw.Models.DTOs.UserAuth
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

