using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAritmetica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSaritmetica : IWSaritmetica
    {
        public clsAritmetica sumar(int numero1, int numero2)
        {
            clsAritmetica obj = new clsAritmetica();
            obj.numeroA = numero1;
            obj.numeroB = numero2;
            obj.respuesta = obj.numeroA + obj.numeroB;
            
            return obj;
        }
    }
}
