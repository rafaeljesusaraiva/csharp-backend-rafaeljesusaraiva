namespace rjsBackend.Models
{
    public class ProjectSEO
    {
        public int Id { get; set; }

        public string MetaTitle { get; set; } = default!;

        public string MetaDescription { get; set; } = default!;

        public string MetaCharset { get; set; } = default!;

        public string MetaLanguage { get; set; } = default!;

        public string MetaAuthor { get; set; } = default!;

        public string MetaCopyright { get; set; } = default!;

        public DateTime MetaDate { get; set; } = default!;

        public string OpenGraphImage { get; set; } = default!;

        public string Keywords { get; set; } = default!;

        // References

        public int ProjectId { get; set; } // Required foreign key property

        public Project Project { get; set; } = default!; // Required reference navigation to principal
    }
}
