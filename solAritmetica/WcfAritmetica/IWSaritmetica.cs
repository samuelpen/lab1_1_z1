using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAritmetica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSaritmetica
    {

        [OperationContract]
        clsAritmetica sumar(int numero1, int numero2);

    }
    [DataContract]
    public class clsAritmetica
    {
        [DataMember]
        public int numeroA { get; set; }
        [DataMember]
        public int numeroB { get; set; }
        [DataMember]
        public int respuesta { get; set; }
    }       
}
