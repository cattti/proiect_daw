using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Models.DTOs;

namespace proiect_daw.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class databaseController : ControllerBase
	{
        private readonly clasaContext _clasaContext;

        public databaseController(clasaContext clasaContext)
        {
            _clasaContext = clasaContext;
        }


        [HttpGet("ArtworkGet")]
        public async Task<IActionResult> GetArtwork()
        {
            return Ok(await _clasaContext.Artworks.ToListAsync());
        }


        [HttpPost("ArtworkPost")]
        ///adaugare inregistrare in tabel
        public async Task<IActionResult> Create(ArtworkDto artworkDto)
        {


            var project = await _clasaContext.Projects.FindAsync(artworkDto.ProjectId);

            var newArtwork = new Artwork
            {
                Id = Guid.NewGuid(),
                Title = artworkDto.Title,
                Description = artworkDto.Description,
                ArtType = artworkDto.ArtType,
                Project = project
               
            };

            //add new item
            await _clasaContext.AddAsync(newArtwork);
            await _clasaContext.SaveChangesAsync();

            return Ok(newArtwork);
        }








        [HttpPost("UserPost")]
        public async Task<IActionResult> PostUser(UserDto userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create a new User entity from the DTO
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Age = userDTO.Age,
                Password = userDTO.Password,
                Username = userDTO.Username,
                Email = userDTO.Email,
                Role = userDTO.Role
                // Add more properties as needed
            };

            await _clasaContext.Users.AddAsync(user);
            await _clasaContext.SaveChangesAsync();

            // Return a success response
            return Ok(user);
        }

    }
}

