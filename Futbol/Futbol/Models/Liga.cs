using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace futbol.Models
{
    public class Liga
    {
        public int ligaID { get; set; }
        public String nombreLiga { get; set; }
        public String anioFundacion { get; set; }
        public String nombrePais { get; set; }
        public byte[] logoLiga { get; set; }

    }
}