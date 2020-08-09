using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFinal.Models
{
    public class Pelicula
    {
        private String nombre;

        public int ID { get; set; }
        public String Titulo { get; set; }
        public String Genero { get; set; }
        public int Duracion { get; set; }

    }
}