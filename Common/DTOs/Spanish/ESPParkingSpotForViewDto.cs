using Common.Enums;

namespace Common.DTOs.Spanish
{
    public class ESPParkingSpotForViewDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Deshabilitada { get; set; }
        public int Eliminada { get; set; }
        public ESPParkingDto? Estacionamiento { get; set; }
    }
}
