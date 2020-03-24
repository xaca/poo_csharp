using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia
{
    class Paquete
    {
        private Galleta[] galletas;
        private Regalo regalo;

        public Paquete(int total_galletas)
        {
            galletas = new Galleta[total_galletas];
            for (int i = 0; i < total_galletas; i++)
            {
                galletas[i] = new Galleta();
                Console.WriteLine(galletas[i].Nombre);
            }
        }

        public Paquete(int total_galletas,bool tiene_regalo)
        {
            if(tiene_regalo)
            {
                regalo = new Regalo("Caja sorpresa");
            }

            galletas = new Galleta[total_galletas];
            for (int i = 0; i < total_galletas; i++)
            {
                galletas[i] = new Galleta();
                Console.WriteLine(galletas[i].Nombre);
            }
        }

    }
}
