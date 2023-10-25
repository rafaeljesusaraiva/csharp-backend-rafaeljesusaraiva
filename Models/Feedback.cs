using System.ComponentModel.DataAnnotations;

namespace rjsBackend.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [RegularExpression(@"^([0-5](\.\d)?)$|^5$",
            ErrorMessage = "Rating must be between 0 and 5 in 0.1 increments.")]
        public float Rating { get; set; }

        public string Description { get; set; } = default!;

        public int UserId { get; set; } // Required Foreign Key

        public User User { get; set; } = null!; // Required reference navigation to User
    }
}
