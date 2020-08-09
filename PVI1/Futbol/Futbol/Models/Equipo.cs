using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbol.Models
{
    public class Equipo
    {
        [Key]
        public int equipoID { get; set; }
        public String nombreEquipo { get; set; }

        public String nombreEstadio { get; set; }

        [ForeignKey("Liga")]
        public int ligaID { get; set; }
        public Liga Liga { get; set; }

        public virtual ICollection<Jugador> Jugadores { get; set; }

    }
}