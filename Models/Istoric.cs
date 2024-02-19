using System;
using proiect_daw.Models.Base;
namespace proiect_daw.Models
{
    public class Istoric : BaseEntity
    {
        public string City { get; set; }

        public string Story { get; set; }


        //Artwork relation
        public Artwork Artwork { get; set; } = default!;
        public Guid ArtworkId { get; set; }
}
}

