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
            Galleta g = new Galleta("La fortuna", "Amarillo", 1, 1500);
            //�Cual es la salida del programa?
            if (g.Tiene_chispas)
            {
                Console.WriteLine(g.Nombre + " " + g.Precio * 3);
            }

            float x = 0, y=0, delta = .5f;
            Galleta temp;

            for (int i = 1; i <= 1; i++)
            {
                //temp = new Galleta(x+(i*delta),y);
                temp = new Galleta(2,3);//Asignaci�n, casting implicito
                //temp.Id = (int)3.5f;//Casting explicito
                temp.ObtenerCoordenadas();
            }

            Galleta galleta = new GalletaCuadrada();

            galleta.FechaVencimiento();
            Console.WriteLine(galleta.Nombre);
            
            ((GalletaCuadrada)galleta).Congelar();
            Console.ReadKey();

            Galleta[] hijas = { new GalletaCuadrada(), new Galleta()};
        }
    }
}
