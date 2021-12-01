using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib.Database
{
    public class BJContext : DbContext
    {
        private readonly string sqlServerUrl = @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;";

        public DbSet<Player> players;

        public DbSet<Result> results;

        public List<Player> getPlayers() 
        {
            using (var db = new BJContext())
            {
                return db.players.ToList();
            }
        }

        public List<Result> getResults()
        {
            using (var db = new BJContext())
            {

                return db.results.ToList();
            }
        }

        public void saveRound(List<Player> players, Player winner)
        {
            using (var db = new BJContext())
            {
                Result result = new Result();

                result.date = new DateTime().ToShortDateString();

                db.results.Add(new Result());

                foreach (Player player in players) 
                {
                    player.result = result.id;

                    db.players.Add(player);
                }

                result.winner = winner.id;

                db.SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlServerUrl);
        }

    }
}
