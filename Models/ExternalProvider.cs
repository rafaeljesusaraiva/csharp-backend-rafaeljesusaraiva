namespace rjsBackend.Models
{
    public class ExternalProvider
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string RefreshToken { get; set; } = default!;

        public string AccessToken { get; set; } = default!;

        public int UserId { get; set; } // Required Foreign Key

        public User User { get; set; } = null!; // Required reference navigation to User
    }
}
