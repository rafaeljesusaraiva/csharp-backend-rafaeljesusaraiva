namespace rjsBackend.Models
{
    public class Moodboard
    {
        public int Id { get; set; }

        public string Title { get; set; } = default!;

        public string? Description { get; set; }

        public string Slug { get; set; } = default!;

        public bool Approved { get; set; } = false;

        // References

        public int ProjectId { get; set; }

        public Project Project { get; set; } = default!; // one-to-one
        
        public List<MoodboardMedia> MoodboardMedia { get; } = new(); // many-to-many
    }
}
