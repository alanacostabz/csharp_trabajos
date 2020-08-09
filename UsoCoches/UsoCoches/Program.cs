using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); //crear objeto/instancia de coche
            //dar un estado inicial a nuestro coche;
            Coche coche2 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche1.getInfoCoche());
            //coche2.setExtras(true,"cuero");
            Console.WriteLine(coche2.getExtras());
        }
    }

    class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";
            
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";
        }

        public String getInfoCoche()
        {
            return "Información del coche: ruedas " + ruedas + " largo: " + largo + " ancho: " + ancho;
        }

        public void setExtras(bool Climatizador, String Tapiceria)
        {
            this.climatizador = Climatizador;
            this.tapiceria = Tapiceria;
        }

        public String getExtras()
        {
            return "Extras del coche:\nTapicería: " + tapiceria + " Climatizador: " + climatizador;
        }


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}
