namespace EFrelationsANDmigrations.Models
{
    public class Sensei
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }

        public ICollection<Study> Studies { get; set; }
    }
}
