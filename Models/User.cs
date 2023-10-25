using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace rjsBackend.Models
{
        public class User
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; } = default!;

        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = default!;

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string? PhoneNumber { get; set; }

        [Url(ErrorMessage = "Invalid URL for profile picture.")]
        public string? ProfilePicture { get; set; }

        [Required(ErrorMessage = "Permission is required.")]
        [RegularExpression("Client|Administrator", ErrorMessage = "Invalid Permission")]
        public string Permission { get; set; } = "Client";

        public bool IsVerified { get; set; } = false;

        // Creates a cryptographically secure random key string.
        private static string CreateSecureRandomString(int count = 64) =>
    Convert.ToBase64String(RandomNumberGenerator.GetBytes(count));

        public string? VerificationCode { get; set; } = CreateSecureRandomString(6);

        public bool ReferenceUsed { get; set; } = false;

        // References
        public ICollection<SocialContact> SocialContacts { get; } = new List<SocialContact>();
        public References? FinalClient { get; set; } = null;
        public ICollection<References> ReferredClients { get; } = new List<References>();
        public ICollection<ExternalProvider> ExternalProviders { get; } = new List<ExternalProvider>();
        public ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();

        public List<Project> Projects { get; } = new(); // many-to-many
    }
}
