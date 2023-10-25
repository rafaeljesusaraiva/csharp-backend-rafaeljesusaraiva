namespace rjsBackend.Models
{
    public class AppointmentPayment
    {
        public int Id { get; set; }

        public string Method { get; set; } = default!;

        public string Status { get; set; } = default!;

        public float Value { get; set; }

        public DateOnly Date { get; set; } = default!;

        // References

        public int AppointmentId { get; set; }

        public Appointment Appointment { get; set; } = default!;
    }
}
