using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilitiesLib.Database
{
    [Table("Players")]
    public class Player
    {
        [
           Key
        ]
        public int id { get; set; }

        public string name { get; set; }

        public int score { get; set; }

        [ForeignKey("Result")]
        public int result;
    }
}
