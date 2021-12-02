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
        // Data Source=localhost\SQLEXPRESS;Integrated Security=True

        private readonly string sqlServerUrl = @"Data Source=localhost\SQLEXPRESS;Integrated Security=True";

            //@"Server=localhost\SQLEXPRESS;Database=Blackjack;Trusted_Connection=True;";

        public DbSet<Player> Players { get; set; }

        public DbSet<Result> Results { get; set; }

        //public BJContext(DbContextOptions<BJContext> options) : base(options)
        //{

        //}
        public BJContext()
        {
            this.Database.EnsureCreated();
        }
        public List<Player> getPlayers() 
        {
            using (var db = new BJContext())
            {
                return db.Players.ToList();
            }
        }

        public List<Result> getResults()
        {
            using (var db = new BJContext())
            {

                return db.Results.ToList();
            }
        }

        public void saveRound(List<Player> players, Player winner)
        {
            using (var db = new BJContext())
            {
                Result result = new Result();

                result.date = new DateTime().ToShortDateString();

                

                foreach (Player player in players) 
                {
                    player.result = result.id;

                    db.Players.Add(player);
                }

                result.winner = winner.id;

                db.Results.Add(result);

                db.SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlServerUrl);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Player>().ToTable("Players");
        //}
    }
}
