namespace rjsBackend.Models
{
    public class ProjectType
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string Slug { get; set; } = default!;

        // References

        public List<Project> Projects { get; } = new(); // many-to-many
    }
}
