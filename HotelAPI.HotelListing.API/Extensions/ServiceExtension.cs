using HotelAPI.HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.HotelListing.API.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy("Cors Policy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HotelDbContext>(option =>
                option.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }
        
    }
}
