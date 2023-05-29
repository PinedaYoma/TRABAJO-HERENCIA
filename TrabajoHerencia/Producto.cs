using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoHerencia
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string NumeroSerie { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Número de serie: " + NumeroSerie);
        }
    }
}