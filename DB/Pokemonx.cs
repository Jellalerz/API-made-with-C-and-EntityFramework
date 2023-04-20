using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Pokemonx
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Pokemon { get; set; }
        public string? Pokemon { get; set; }
        public int HP { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }

        public int Special_Attack { get; set; }
        public int Special_Defense { get; set; }
        public int Speed { get; set; }

        public string Img { get; set; }

    }
}
