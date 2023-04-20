using System.ComponentModel.DataAnnotations;

namespace EFrelationsANDmigrations.Models
{
    public class Study
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<StudentsStudies> StudentsStudies { get; set; }
        public Sensei Sensei { get; set; }
    }
}
