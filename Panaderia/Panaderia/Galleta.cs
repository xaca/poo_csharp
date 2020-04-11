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
        private float precio;
        private bool tiene_chispas;
        private int id;
        private float x, y;

        public Galleta()
        {
            //this.Nombre = "Chip";
            this.Precio = 2000.0f;            
            
        }

        public Galleta(byte x, byte y)
        {
            Console.WriteLine("Llamo al constructor con bytes");
            this.x = x;
            this.y = y;
        }

        /*public Galleta(int x, int y)
        {
            Console.WriteLine("Llamo al constructor con enteros");
            this.x = x;
            this.y = y;
        }*/

        public Galleta(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Galleta(float peso)
        {
            this.Peso = peso;
        }

        public Galleta(float precio,string nombre)
        {
            this.Precio = precio;
        }

        public Galleta(string nombre, string color, float peso, float precio)
        {
            Nombre = nombre;
            Color = color;
            Peso = peso;
            Precio = precio;
        }

        /* Esto es un error, porque la firma del constructor ya existe y no importa
         * si cambiamos el nombre del parametro.
        public Galleta(string x, string y, float peso, float precio)
        {
            Nombre = nombre;
            Color = color;
            Peso = peso;
            Precio = precio;
        }*/

        public Galleta(bool bandera)
        {
            if (bandera)
            {
                Console.WriteLine("Galleta de degustaci�n");
            }
            else
            {
                Console.WriteLine("Galleta para la venta");
            }
        }

        public void ObtenerCoordenadas()
        {
            Console.WriteLine("(x:" + x+",y:"+y +")");
        }

        public void FechaDeVencimiento()
        {
            Console.WriteLine("23 de abril 20202");
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Precio { get => precio; set => precio = value; }
        public bool Tiene_chispas { get => tiene_chispas; set => tiene_chispas = value; }
        public int Id { get => id; set => id = value; }
    }
}
