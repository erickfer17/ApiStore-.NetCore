﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Categories
    {   
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public ICollection<Stores> CategoryStore { get; set; }
    }
}
