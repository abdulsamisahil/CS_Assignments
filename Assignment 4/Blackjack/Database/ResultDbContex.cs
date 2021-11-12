using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCardLib; 
namespace Blackjack.Database
{
    public class ResultDbContex : DbContext
    {
        public ResultDbContex() 
        {

        }
      
        public DbSet<Player> Players { get; set; }
        public DbSet<Hand> Hands { get; set;  }
    }
}
