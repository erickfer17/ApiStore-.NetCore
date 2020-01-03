
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Owners
    {   
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTimeOffset BirthDay { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Telephone { get; set; }
        [Required]
        public string RFC { get; set; }

        //public ICollection<Stores> OwnerStore { get; set; }
    }
}
