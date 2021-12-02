using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib.Database
{
    public class Repository
    {
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
        public void updateName(string name, int id)
        {
            try
            {
                var db = new BJContext();
                Player player = db.Players.First(x => x.id == id);
                //Player player = ( from p in getPlayers()
                //                 where p.id == id
                //                 select p).FirstOrDefault();
                player.name = name;
                db.SaveChanges(); 

            }catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }
        public void deleteRecord(int id)
        {
            try
            {
                var db = new BJContext();
                var player = db.Players.SingleOrDefault(p => p.id == id);
                if (player != null)
                {
                    db.Players.Remove(player);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
