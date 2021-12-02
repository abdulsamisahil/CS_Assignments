using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilitiesLib.Database
{
    [Table("Results")]
    public class Result
    {
        [
          Key
        ]
        public int id { get; set; }
        
        public string date { get; set; }

        [ForeignKey("Player")]
        public int winner;
    }
}
