using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Models.DTOs;
using proiect_daw.Services.ProjectService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace proiect_daw.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class ProjectController : ControllerBase
        {
            private readonly IProjectService _projectService;

            public ProjectController(IProjectService projectService)
            {
                _projectService = projectService;
        }




        [Authorize(Roles = "Admin")]
        [HttpPost]
            public async Task<IActionResult> CreateProject([FromBody] Project project)
            {
                var createdProject = await _projectService.CreateProjectAsync(project);
                return Ok(createdProject);
            }

            [HttpGet]
            public async Task<IActionResult> GetAllProjects()
            {
                var projects = await _projectService.GetAllProjectsAsync();
                return Ok(projects);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetProjectById(Guid id)
            {
                var project = await _projectService.GetProjectByIdAsync(id);
                if (project == null)
                {
                    return NotFound();
                }
                return Ok(project);
            }



        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
            public async Task<IActionResult> UpdateProject(Guid id, [FromBody] Project project)
            {
                project.Id = id;
                await _projectService.UpdateProjectAsync(project);
                return NoContent();
            }




        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteProject(Guid id)
            {
                await _projectService.DeleteProjectAsync(id);
                return NoContent();
            }
        }
    }


