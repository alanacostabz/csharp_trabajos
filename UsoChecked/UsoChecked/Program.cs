using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
           // checked
           // {
                int numero = int.MaxValue;
                int resultado = unchecked(numero + 20);
                Console.WriteLine(resultado);

          //  }

          

        }
    }
}
