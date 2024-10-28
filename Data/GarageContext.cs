using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class GarageContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Rate> Rates { get; set; }

        public GarageContext(DbContextOptions<GarageContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User luis = new User()
            {
                Id = 1,
                Name = "Luis",
                Password = "lamismadesiempre",
                UserName = "luismitoto@gmail.com",
                IsActive = true,
                Phone = "+543323333",
                State = Common.Enums.UserStates.Enabled
            };



            modelBuilder.Entity<User>().HasData(
                luis);

            Rate rate1 = new Rate()
            {
                Id = 1,
                Description = "Auto",
                Value = 10.0
            };

            Rate rate2 = new Rate()
            {
                Id = 2,
                Description = "Moto",
                Value = 5.0
            };

            Rate rate3 = new Rate()
            {
                Id = 3,
                Description = "Camión",
                Value = 20.0
            };

            Rate rate4 = new Rate()
            {
                Id = 4,
                Description = "Bicicleta",
                Value = 2.0
            };

            Rate rate5 = new Rate()
            {
                Id = 5,
                Description = "Colectivo",
                Value = 15.0
            };

            modelBuilder.Entity<Rate>().HasData(rate1, rate2, rate3, rate4, rate5);


            ParkingSpot parkingSpot1 = new ParkingSpot()
            {
                Id = 1,
                Description = "1A",
                Disabled = 0,
                Deleted = 0,
            };

            ParkingSpot parkingSpot2 = new ParkingSpot()
            {
                Id = 2,
                Description = "1B",
                Disabled = 0,
                Deleted = 0,
            };

            ParkingSpot parkingSpot3 = new ParkingSpot()
            {
                Id = 3,
                Description = "1C",
                Disabled = 0,
                Deleted = 0,
            };

            ParkingSpot parkingSpot4 = new ParkingSpot()
            {
                Id = 4,
                Description = "2A",
                Disabled = 0,
                Deleted = 0,
            };

            modelBuilder.Entity<ParkingSpot>().HasData(parkingSpot1, parkingSpot2, parkingSpot3, parkingSpot4);


            Parking parking1 = new Parking()
            {
                Id = 1,
                LicensePlate = "ABC123",
                EntryTime = new DateTime(2023, 10, 1, 8, 0, 0),
                ExitTime = new DateTime(2023, 10, 1, 10, 0, 0),
                Cost = 20.0,
                EntryUserId = "1",
                ExitUserId = "1",
                ParkingSpotId = 1,
                IsDeleted = false
            };

            Parking parking2 = new Parking()
            {
                Id = 2,
                LicensePlate = "DEF456",
                EntryTime = new DateTime(2023, 10, 1, 9, 0, 0),
                ExitTime = new DateTime(2023, 10, 1, 11, 0, 0),
                Cost = 20.0,
                EntryUserId = "1",
                ExitUserId = "1",
                ParkingSpotId = 2,
                IsDeleted = false
            };

            Parking activeParking = new Parking()
            {
                Id = 3,
                LicensePlate = "GHY456",
                EntryTime = new DateTime(2024, 10, 1, 9, 0, 0),
                EntryUserId = "1",
                ParkingSpotId = 1,
                IsDeleted = false
            };

            Parking activeParking2 = new Parking()
            {
                Id = 4,
                LicensePlate = "AGR405",
                EntryTime = new DateTime(2022, 11, 1, 9, 0, 0),
                EntryUserId = "1",
                ParkingSpotId = 2,
                IsDeleted = false
            };

            modelBuilder.Entity<Parking>().HasData(parking1, parking2, activeParking, activeParking2);


            base.OnModelCreating(modelBuilder);
        }
    }
}
