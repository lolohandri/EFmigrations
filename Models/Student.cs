using System.ComponentModel.DataAnnotations;

namespace EFrelationsANDmigrations.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
        public string Number { get; set; }
        public bool IsMentor { get; set; }
        public Group Group { get; set; }
        public ICollection<StudentsStudies> StudentsStudies { get; set; }
    }
}
