namespace Data.Entities
{
    //El equivalente a Cochera en el front
    public class ParkingSpot
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Disabled { get; set; }
        public int Deleted { get; set; }
    }
}