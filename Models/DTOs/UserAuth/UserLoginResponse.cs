﻿using System;
namespace proiect_daw.Models.DTOs.UserAuth
{
    public class UserLoginResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }


        public UserLoginResponse(User user, string token)
        {
            Id = user.Id;
            UserName = user.Username;
            Token = token;
        }
    }
}

