using Common.Enums;

namespace Common.DTOs
{
    public class GarageForViewDto
    {
        public string Number { get; set; }
        public GarageStatus Status { get; set; } = GarageStatus.Enabled;
        public string? Plate { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}
