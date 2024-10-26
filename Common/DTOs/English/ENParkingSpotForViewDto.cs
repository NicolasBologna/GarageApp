using Common.Enums;

namespace Common.DTOs.English
{
    public class ENParkingSpotForViewDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Disabled { get; set; }
        public int Deleted { get; set; }
    }
}
