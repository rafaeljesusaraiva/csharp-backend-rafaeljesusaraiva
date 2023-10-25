namespace rjsBackend.Models
{
    public class References
    {
        public int Id { get; set; }

        public int FinalClientId { get; set; } // Required Foreign Key

        public User FinalClient { get; set; } = null!; // Required reference navigation to User

        public int ReferredClientId { get; set; } // Required Foreign Key

        public User ReferredClient { get; set; } = null!; // Required reference navigation to User
    }
}
