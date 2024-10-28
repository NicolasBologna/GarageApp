using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    //El equivalente a estacionamiento en el front, donde se registra cada vehículo que entra, permanece y sale del estacionamiento
    public class Parking
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public double? Cost { get; set; }
        public string EntryUserId { get; set; }
        public string? ExitUserId { get; set; }
        public ParkingSpot ParkingSpot { get; set; }

        [ForeignKey("ParkingSpot")]
        public int ParkingSpotId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
