using System;
namespace proiect_daw.Models.DTOs
{
	public class ArtworkDto
	{
		public Guid Id { get; set; }
		public Guid ProjectId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ArtType { get; set; }
	}
}

