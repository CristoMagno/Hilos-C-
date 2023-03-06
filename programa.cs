using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo2Hilos
{
    internal class Program
    {
        static void procesos(object o)
        {
            Proceso proc = (Proceso)o;
            do
            {
                Console.WriteLine(proc);
                if (proc.Status.Equals("ejecutando"))
                {
                    Thread.Sleep(2500);
                    proc.Status = "finalizado";
                }
                if (!proc.Status.Equals("finalizado"))
                {
                    Thread.Sleep(500);
                }
                if (proc.Status.Equals("planeado"))
                {
                    Thread.Sleep(1500);
                    proc.Status = "ejecutando";
                }
            } while (!proc.Status.Equals("finalizado"));
            Console.WriteLine("El proceso {0} ha finalizado",proc.NombreProceso);
        }
        static void Main(string[] args) 
        {
            Proceso x1, x2, x3, x4;
            x1 = new Proceso("Ejercicio 1 ");
            x2 = new Proceso("Ejercicio 2 ");
            x3 = new Proceso("Ejercicio 3 ");
            x4 = new Proceso("Ejercicio 4 ");
            Thread h1, h2, h3, h4;
            h1 = new Thread(procesos);
            h2 = new Thread(procesos);
            h3 = new Thread(procesos);
            h4 = new Thread(procesos);
            h1.Start(x1);
            h2.Start(x2);
            h3.Start(x3);
            h4.Start(x4);
            Console.ReadKey();

        }
    }
}
