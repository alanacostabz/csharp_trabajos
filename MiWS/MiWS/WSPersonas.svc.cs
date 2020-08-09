using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MiWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona ObtenerPersona(string id)
        {
            if (id == "0") 
            {
                return new Persona() { Nombre = "Alan", edad = 23 };
            } else if (id == "1")
            {
                return new Persona() { Nombre = "Arthur", edad = 32 };
            } else
            {
                return new Persona() { Error = "Persona no encontrada" };
            }
        }
    }
}
