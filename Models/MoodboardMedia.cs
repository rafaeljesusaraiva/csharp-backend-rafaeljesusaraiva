namespace rjsBackend.Models
{
    public class MoodboardMedia
    {
        public int Id { get; set; }

        public int MediaId { get; set; }

        public MediaStorage Media { get; set; } = default!; // one-to-many
    }
}
