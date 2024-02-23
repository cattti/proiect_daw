using Microsoft.EntityFrameworkCore;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Repositories;
using proiect_daw.Repositories.GenericRepository;
namespace proiect_daw.Repositories.ArtworkRepository { 

public class ArtworkRepository : GenericRepository<Artwork>, IArtworkRepository
{
    public ArtworkRepository(clasaContext context) : base(context)
    {
    }

    public async Task<List<Artwork>> GetArtworkByProjectId(Guid projectId)
    {
        return await _table.Where(a => a.ProjectId == projectId).ToListAsync();
    }
}


}