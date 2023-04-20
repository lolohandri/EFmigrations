using Microsoft.EntityFrameworkCore;

namespace EFrelationsANDmigrations.Models
{
    public class StudentsStudies
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid StudyId { get; set; }
        public Study Study { get; set;}
    }
}
