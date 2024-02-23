using Microsoft.AspNetCore.Mvc;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Models.DTOs;
using proiect_daw.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect_daw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorController : ControllerBase
    {
        private readonly ICollaboratorService _collaboratorService;

        public CollaboratorController(ICollaboratorService collaboratorService)
        {
            _collaboratorService = collaboratorService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollaborator([FromBody] Collaborator collaborator)
        {
            var createdCollaborator = await _collaboratorService.CreateCollaboratorAsync(collaborator);
            return Ok(createdCollaborator);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCollaborators()
        {
            var collaborators = await _collaboratorService.GetAllCollaboratorsAsync();
            return Ok(collaborators);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCollaboratorById(Guid id)
        {
            var collaborator = await _collaboratorService.GetCollaboratorByIdAsync(id);
            if (collaborator == null)
            {
                return NotFound();
            }
            return Ok(collaborator);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCollaborator(Guid id, [FromBody] Collaborator collaborator)
        {
            collaborator.Id = id; // Asigură-te că id-ul colaboratorului este setat corect
            await _collaboratorService.UpdateCollaboratorAsync(collaborator);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollaborator(Guid id)
        {
            await _collaboratorService.DeleteCollaboratorAsync(id);
            return NoContent();
        }
    }
}
