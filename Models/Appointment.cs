namespace rjsBackend.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public float? totalPrice { get; set; }

        public string? SlugOrcamento { get; set; }

        public string? SlugProposta { get; set; }

        // References

        public int ProjectId { get; set; }

        public Project Project { get; set; } = default!;

        public ICollection<AppointmentPayment> AppointmentPayments { get; } = new List<AppointmentPayment>(); // one-to-many

        public List<FileStorage> Quote { get; set; } = new(); // many-to-many

        public List<FileStorage> Proposal { get; set; } = new(); // many-to-many
    }
}
