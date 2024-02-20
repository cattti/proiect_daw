﻿using System;
using System.ComponentModel.DataAnnotations;

namespace proiect_daw.Models.DTOs.UserAuth
{
    public class UserRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

