using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.ObtenerInstancia();
            Singleton s2 = Singleton.ObtenerInstancia();

            string resultado;

            if (s1 == s2)
            {
                resultado = "Ambas instancias son la misma.";
            }
            else
            {
                resultado = "Son diferentes instancias.";
            }

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
