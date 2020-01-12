using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia
{
    class Galleta
    {
        private string nombre;
        private string color;
        private float peso;

        public Galleta(float peso)
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
        public float Peso { get => peso; set => peso = value; }
    }
}
