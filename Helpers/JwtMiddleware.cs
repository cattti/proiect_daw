﻿using System;
using proiect_daw.Helpers.JwtUtils;
//using proiect_daw.Services;

namespace proiect_daw.Helpers
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtil)
        //{
        //    // "Bearer sdsfkdkgkfgkflkgflgklfg"
        //    var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        //    var userId = jwtUtil.GetUserId(token);
        //    if (userId != null)
        //    {
        //        context.Items["User"] = userService.GetById(userId.Value);
        //    }

        //    await _next(context);
        //}
    }
}

