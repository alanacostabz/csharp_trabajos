using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MiWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersonas
    {

        [OperationContract]
        Persona ObtenerPersona(String id);

        // TODO: agregue aquí sus operaciones de servicio
    }

    [DataContract]
    public class Persona: BaseRespuesta
    {
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public int edad { get; set; }
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class BaseRespuesta
    {
        public string mensajeRespuesta { get; set; }
         public string Error { get; set; }
    }

    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
