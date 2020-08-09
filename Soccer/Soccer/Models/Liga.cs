using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soccer.Models
{
    public class Liga
    {
        public int ligaID { get; set; }
        public String nLiga { get; set; }
        public int aFundacion { get; set; }
        public String Pais { get; set; }
        public byte[] logoLiga { get; set; }

    }
}