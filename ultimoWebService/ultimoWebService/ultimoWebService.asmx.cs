using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ultimoWebService
{
    /// <summary>
    /// Descripción breve de ultimoWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class ultimoWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola mundo!!!";
        }

        [WebMethod]
        public List<Int32> numerosMelate()
        {
            List<Int32> numeros = new List<int>();
            Random aleatorio = new Random();
            numeros.Add(aleatorio.Next(1, 54));
            numeros.Add(aleatorio.Next(1, 54));
            numeros.Add(aleatorio.Next(1, 54));
            numeros.Add(aleatorio.Next(1, 54));
            numeros.Add(aleatorio.Next(1, 54));
            numeros.Add(aleatorio.Next(1, 54));
            return numeros;
        }

    }
}
