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
            //Paquete paquete = new Paquete(12);                     
            Galleta[] galletas = { new Galleta(), new GalletaRectangular() };
            Galleta g = new GalletaRectangular();

            g.FechaDeVencimiento();

            ((GalletaRectangular)g).Congelar();

            

            Console.ReadKey();
        }
    }
}
