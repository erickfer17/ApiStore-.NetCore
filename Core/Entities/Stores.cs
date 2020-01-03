
using System;
using System.ComponentModel.DataAnnotations;
namespace Core.Entities
{
    public class Stores
    {   
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int IdCategory { get; set; }
        public Categories Category { get; set; }
        [Required]
        public int IdOwner { get; set; }
        public Owners Owner { get; set; }
    }
}
