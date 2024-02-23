using System;
using proiect_daw.Models;

namespace proiect_daw.Services.ProjectService
{
    public interface IProjectService
    {
        Task<Project> CreateProjectAsync(Project project);
        Task<List<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectByIdAsync(Guid id);
        Task UpdateProjectAsync(Project project);
        Task DeleteProjectAsync(Guid id);
    }
}

