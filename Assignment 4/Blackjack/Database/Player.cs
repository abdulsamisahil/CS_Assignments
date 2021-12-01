using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blackjack.Database
{
    public class Player
    {
        [
            DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),
            Key()
        ]
        public int id;

        public string name;

        public int score;

        [ForeignKey("Result")]
        public int result;
    }
}
