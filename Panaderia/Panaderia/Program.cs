using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia
{
    class Program
    {
        static void Main(string[] args)
        {
            Galleta galleta;
            galleta = new Galleta();

            galleta.Nombre = "Galleta de la fortuna";

            Console.WriteLine("El color es:"+galleta.Color);

            Console.WriteLine("La galleta:"+galleta.Nombre+" pesa:"+galleta.Peso);
            Console.ReadKey();

        }
    }
}
