//using System;
//using proiect_daw.Helpers.JwtUtils;
//using proiect_daw.Models;
//using proiect_daw.Models.DTOs.UserAuth;
//using System.Data;
//using proiect_daw.Models.Enums;
//using proiect_daw.Repositories.UserRepository;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//namespace proiect_daw.Services
//{
//    public class UserService : IUserService
//    {
//        private readonly IUserRepository _userRepository;
//        private readonly IJwtUtils _jwtUtils;

//        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
//        {
//            _userRepository = userRepository;
//            _jwtUtils = jwtUtils;
//        }

//        public User GetById(Guid id)
//        {
//            return _userRepository.FindById(id);
//        }

//        public async Task<UserLoginResponse> Login(UserLoginDto userDto)
//        {
//            var user = await _userRepository.FindByUsername(userDto.UserName);

//            if (user == null || !BCryptNet.Verify(userDto.Password, user.Password))
//            {
//                return null;
//            }
//            if (user == null) return null;

//            var token = _jwtUtils.GenerateJwtToken(user);
//            return new UserLoginResponse(user, token);
//        }

//        public async Task<bool> Register(UserRegisterDto userRegisterDto, UserRole userRole)
//        {
//            var userToCreate = new User
//            {
//                Username = userRegisterDto.UserName,
//                FirstName = userRegisterDto.FirstName,
//                LastName = userRegisterDto.LastName,
//                Email = userRegisterDto.Email,
//                Role = userRole,
//                Password = BCryptNet.HashPassword(userRegisterDto.Password)
//            };

//            _userRepository.Create(userToCreate);
//            return await _userRepository.SaveAsync();
//        }
//    }
//}

