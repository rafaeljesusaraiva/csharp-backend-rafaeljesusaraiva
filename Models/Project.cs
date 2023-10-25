using System.ComponentModel.DataAnnotations;

namespace rjsBackend.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = default!;

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; } = default!;

        public string? Description { get; set; }

        [Required(ErrorMessage = "Cover Image is required.")]
        [Url(ErrorMessage = "Invalid URL format for Cover Image.")]
        public string CoverImage { get; set; } = default!;

        [Required(ErrorMessage = "Date Begin is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date format for Date Begin.")]
        public DateTime DateBegin { get; set; } = default!;

        [Required(ErrorMessage = "Date End is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date format for Date End.")]
        [DateEndGreaterThanDateBegin(ErrorMessage = "Date End must be greater than Date Begin.")]
        public DateTime DateEnd { get; set; } = default!;

        [Required(ErrorMessage = "Slug is required.")]
        [RegularExpression("^[a-zA-Z0-9-]*$", ErrorMessage = "Invalid Slug format.")]
        public string Slug { get; set; } = default!;

        public bool IsHidden { get; set; } = false;

        public bool IsBlocked { get; set; } = false;

        public bool IsProtected { get; set; } = false;

        public string? Password { get; set; }

        // References
        public List<User> Clients { get; } = new(); // many-to-many

        public ProjectSEO? ProjectSEO { get; set; } // one-to-one

        public MediaStorage? Cover { get; set; } // one-to-one

        public ICollection<MediaStorage> Media { get; } = new List<MediaStorage>(); // one-to-many

        public List<ProjectType> ProjectTypes { get; } = new(); // many-to-many

        public Moodboard? Moodboard { get; set; } // one-to-one

        public ICollection<Appointment> Appointments { get; } = new List<Appointment>(); // one-to-many
    }
}
