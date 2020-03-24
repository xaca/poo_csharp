using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia
{
    class GalletaRectangular:Galleta
    {
        private bool borde;

        public void Congelar()
        {
            Console.WriteLine("Congelando...");
        }

        public void BordeRectangular(bool borde)
        {
            this.borde = borde;
        }
    }
}
