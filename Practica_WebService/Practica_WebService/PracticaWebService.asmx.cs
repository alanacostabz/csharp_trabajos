using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica_WebService
{
    /// <summary>
    /// Descripción breve de PracticaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class PracticaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable LeeXML()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            String ruta = AppDomain.CurrentDomain.BaseDirectory;
            ds.ReadXml(ruta + "\\Musica.xml");

            dt = ds.Tables[0];

            return dt;
        }

        [WebMethod]
        public ArrayList LeeTXT()
        {

            String ruta = AppDomain.CurrentDomain.BaseDirectory;
            StreamReader lector = new StreamReader(ruta + "\\prueba.txt");
            string linea = "";
            ArrayList texto = new ArrayList();
            while (linea != null)
            {
                linea = lector.ReadLine();
                if (linea != null)
                    texto.Add(linea);
            }
            lector.Close();

            return texto;
        }
    }
}
