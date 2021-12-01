using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilitiesLib.Database
{
    public class Result
    {
        [
            DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),
            Key()
        ]
        public int id { get; set; }
        
        public string date;

        [ForeignKey("Player")]
        public int winner;
    }
}
