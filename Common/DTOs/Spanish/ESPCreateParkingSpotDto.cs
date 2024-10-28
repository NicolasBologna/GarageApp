using System.ComponentModel.DataAnnotations;

namespace Common.DTOs.Spanish
{
    public class ESPCreateParkingSpotDto
    {
        [Required]
        public string Descripcion { get; set; }
    }
}
