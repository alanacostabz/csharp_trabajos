using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerDLL
{
    public class ClaseDLL
    {
        public void HolaMundo(String nombre)
        {
            System.Console.WriteLine("Hola " + nombre + "!!!");
            System.Console.ReadLine();
        }

        public void conectaBaseDatos()
        {
            System.Console.WriteLine("Me estoy conectando a la base de datos y estoy borrandola");
            System.Console.ReadLine();
        }
    }
}
