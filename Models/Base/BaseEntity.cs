﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proiect_daw.Models.Base
{
	public class BaseEntity:IBaseEntity
    {
		    

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public Guid Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}


