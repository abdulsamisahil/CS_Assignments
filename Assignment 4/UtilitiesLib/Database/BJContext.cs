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
        public DbSet<Player> players;

        public DbSet<Result> results;

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
    }
}
