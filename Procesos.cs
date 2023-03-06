using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2Hilos
{
    internal class Proceso
    {
        //Se declaran la variables del programa
        private string nombreProceso;
        private string status;
        public Proceso(string n)
        {
            nombreProceso = n;
            status = "planeado";
        }


        public string Status { get => status; set => status = value; }
        public string NombreProceso { get => nombreProceso; set => nombreProceso = value; }

        override
        public string ToString()
        {
            return nombreProceso + "está en " + status;
        }
    }//fin clase Proceso
}
