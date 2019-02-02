using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_Aplicacion
{
    class Program
    {
        [PruebaPostSharp.AspectoQueInterceptaUnMetodo]
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
        }
    }
}
