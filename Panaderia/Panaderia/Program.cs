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

            Galleta g2 = new GalletaHelado();

            Galleta g = new GalletaRectangular();//Casting implicito
            GalletaRectangular gr;
            //g.BordeRectangular(true); Este metodo es de la hija
            ((GalletaRectangular)g).BordeRectangular(true);

            gr = ((GalletaRectangular)g);//Casting explicito

            ((GalletaHelado)g2).BordeRectangular(true);
            ((GalletaHelado)g2).Congelar();

            ((GalletaRectangular)g2).BordeRectangular(true);

            //gr.FechaDeVencimiento();
            
            /*Galleta g3 = new GalletaRectangular();
            GalletaHelado g4 = new GalletaHelado();
            g3.FechaDeVencimiento();
            g4.FechaDeVencimiento();*/

            Galleta[] galletas = { new Galleta(), new GalletaHelado(), new GalletaRectangular() };

            for (int i = 0; i < galletas.Length; i++)
            {
                Console.WriteLine(galletas[i].Nombre);
            }

            Galleta g5 = new Galleta(true,"Galleta de degustacion");

            g5.ObtenerCoordenadas("Prueba");
            g5.ObtenerCoordenadas();

            Console.ReadKey();
        }
    }
}
