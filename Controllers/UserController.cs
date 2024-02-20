using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using proiect_daw.Models.IdentityAuthentification;
using proiect_daw.Models;

namespace proiect_daw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    public class UserController : ControllerBase
	{
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;


        public UserController(UserManager<IdentityUser> userManager,
                                    RoleManager<IdentityRole> roleManager,
                                            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;

        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] User registerUser, string role )
        {
            //check user exists
            var userExists = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userExists==null)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new Response { Status = "Error", Message = "User already exists" });
            }


            //add user

            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.Username
            };


            if (await _roleManager.RoleExistsAsync(role))
            {


                var result = await _userManager.CreateAsync(user, registerUser.Password);

                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        new Response { Status = "Error", Message = "User failed to create" });
                }


                //add role

                await _userManager.AddToRoleAsync(user, role);
                    return StatusCode(StatusCodes.Status200OK,
                        new Response { Status = "Success", Message = "User created" });
                
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { Status = "Error", Message = "Role does not exist" });
            }






        }
    }


}

