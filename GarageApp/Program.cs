
using Data;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Services;

namespace GarageApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<IGarageRepository, GarageRepository>();
            builder.Services.AddScoped<IGarageService, GarageService>();

            builder.Services.AddDbContext<GarageContext>(dbContextOptions => dbContextOptions.UseSqlite(builder.Configuration["ConnectionStrings:GarageAPIDBConnectionString"]));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
