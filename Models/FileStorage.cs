namespace rjsBackend.Models
{
    public class FileStorage
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string S3_Storage { get; set; } = default!;

        // References

        public List<Appointment> AppointmentsQuote { get; set; } = new(); // many-to-many

        public List<Appointment> AppointmentProposal { get; set; } = new(); // many-to-many
    }
}
