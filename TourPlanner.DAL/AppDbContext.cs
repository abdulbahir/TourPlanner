using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.DAL.DTOs;
using TourPlanner.DTOs;
using System.Configuration;

namespace TourPlanner.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            optionsBuilder.UseNpgsql(connectionString);
        }
    }

}
