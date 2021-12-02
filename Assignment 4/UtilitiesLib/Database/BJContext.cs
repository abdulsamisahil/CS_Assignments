using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
namespace UtilitiesLib.Database
{
    public class BJContext : DbContext
    {

        private readonly string sqlServerUrl = @"Data Source=localhost\SQLEXPRESS;Integrated Security=True";

        public DbSet<Player> Players { get; set; }

        public DbSet<Result> Results { get; set; }
       
        public BJContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlServerUrl);
        }
    }
}
