using AngularCrudWebapi.Model.Data;
using AngularCrudWebapi.Model.Repository.Interface;
using AngularCrudWebapi.Model.Repository.InterfaceImplementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace AngularCrudWebapi
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

            builder.Services.AddDbContext<AplicationDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("CodePlusConnectionString")));

            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        
    }
}
