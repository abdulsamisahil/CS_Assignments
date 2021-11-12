using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class Player
    {

        public Hand Hand { get; set; }
        public string Name { get; set; }

        [Key]
        public int PlayerId { get; set; }
        public PlayerState State { get; set; }
      
        public Player(string name, int id)
        {
            Name = name;
            PlayerId = id;
            Hand = new Hand();
            State = PlayerState.Ready;
        }

        public List<Player> playersList = new List<Player>(); 

        public void AddWinners(Player player)
        {

        }

        public Player()
        {

        }
        
       
    }
}
