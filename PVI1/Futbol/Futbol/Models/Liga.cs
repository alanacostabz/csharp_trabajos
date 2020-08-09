using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Futbol.Models
{
    public class Liga
    {
        [Key]
        public int ligaID { get; set; }

        public String nombreLiga { get; set; }
        public int anioFundacion { get; set; }
        public String nombrePais { get; set; }

        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}