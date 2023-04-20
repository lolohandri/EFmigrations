using System.ComponentModel.DataAnnotations;

namespace EFrelationsANDmigrations.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Year { get; set; }

        public ICollection<Student> Students { get; set;}
    }
}
