namespace rjsBackend.Models
{
    public class SocialContact
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public string? Url { get; set; }

        public int UserId { get; set; } // Required Foreign Key
        public User User { get; set; } = null!; // Required reference navigation to User
    }
}
