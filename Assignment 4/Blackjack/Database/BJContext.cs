using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib;

namespace Blackjack.Database
{
    public class BJContext : DbContext
    {
        public DbSet<Player> players; 

        public List<Player> getPlayers()
        {
            using (var db = new BJContext()) 
            {
                  return db.players.ToList();
            }
        }

        public void addPlayers(List<Player> players) 
        {
            using (var db = new BJContext())
            {

                db.players.AddRange(players);
            }
        }
    }

    public class Result<T>
    {
        public void add(T item) { 
        }

        public T get(T item)
        {

            return item;
        } 
    }
}
