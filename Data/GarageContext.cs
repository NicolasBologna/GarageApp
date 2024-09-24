using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class GarageContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Garage> Garages { get; set; }

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
                State = Enums.UserStates.Enabled
            };

            modelBuilder.Entity<User>().HasData(
                luis);

            base.OnModelCreating(modelBuilder);
        }
    }
}
