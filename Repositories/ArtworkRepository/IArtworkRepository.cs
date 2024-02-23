using proiect_daw.Models;
using proiect_daw.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proiect_daw.Repositories.ArtworkRepository

{
    public interface IArtworkRepository : IGenericRepository<Artwork>
    {
        Task<List<Artwork>> GetArtworkByProjectId(Guid projectId);
    }

}

