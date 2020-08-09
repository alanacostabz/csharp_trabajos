using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbol.Models
{
    public class Jugador
    {
        [Key]
        public int jugadorID { get; set; }
        public String nombreJugador { get; set; }
        public int edadJugador { get; set; }
        public int paisOrigen { get; set; }

        [ForeignKey("Equipo")]
        public int equipoID { get; set; }
        public Equipo Equipo { get; set; }



    }
}