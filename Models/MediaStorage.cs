namespace rjsBackend.Models
{
    public class MediaStorage
    {
        public int Id { get; set; }

        public int Order { get; set; }

        public string Name { get; set; } = default!;

        public string S3Storage_Original { get; set; } = default!;

        public string? S3Storage_Thumbnail { get; set; }

        public string? S3Storage_Medium { get; set; }

        // References

        public int ProjectCoverId { get; set; } // Required foreign key property

        public Project ProjectCover { get; set; } = default!; // Required navigation property

        public int ProjectMediaId { get; set; } // Required foreign key property

        public Project ProjectMedia { get; set; } = default!; // Required navigation property

        public ICollection<MoodboardMedia> MoodboardMedia { get; } = new List<MoodboardMedia>(); // one-to-many

        public List<Moodboard> Moodboards { get; } = new(); // many-to-many
    }
}
