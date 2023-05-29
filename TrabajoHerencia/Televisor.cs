using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoHerencia
{
    internal class Televisor : Producto
    {
        public string Resolucion { get; set; }
        public bool EsSmartTV { get; set; }

        public void MostrarInformacionAdicional()
        {
            Console.WriteLine("Resolución: " + Resolucion);
            Console.WriteLine("Es Smart TV: " + EsSmartTV);
        }
    }
}
