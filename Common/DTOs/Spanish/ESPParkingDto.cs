namespace Common.DTOs.Spanish
{
    public class ESPParkingDto //Estacionamiento
    {
        public int Id { get; set; }
        public string Patente { get; set; }
        public string HoraIngreso { get; set; }
        public string? HoraEgreso { get; set; }
        public double? Costo { get; set; }
        public string IdUsuarioIngreso { get; set; }
        public string? IdUsuarioEgreso { get; set; }
        public int IdCochera { get; set; }
        public bool? Eliminado { get; set; }
    }
}
