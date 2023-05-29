using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoHerencia
{
    internal class Telefono : Producto
    {
        public string Marca { get; set; }
        public string SistemaOperativo { get; set; }

        public void MostrarInformacionAdicional()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Sistema operativo: " + SistemaOperativo);
        }
    }
}
