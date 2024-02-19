using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proiect_daw.Models.Base
{
	public class BaseEntity:IBaseEntity
    {
		    

        [Key]
        //generated value when row is inserted
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]

        public Guid Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
    }
}


