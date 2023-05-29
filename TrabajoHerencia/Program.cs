using System;

namespace TrabajoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del televisor:");
            Televisor televisor = new Televisor();
            Console.WriteLine("Nombre:");
            televisor.Nombre = Console.ReadLine();
            Console.WriteLine("Precio:");
            televisor.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Resolución:");
            televisor.Resolucion = Console.ReadLine();
            Console.WriteLine("Número de Serie:");
            televisor.NumeroSerie = Console.ReadLine();
            Console.WriteLine("¿Es smart?:");
            televisor.EsSmartTV = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Ingrese los datos del teléfono:");
            Telefono telefono = new Telefono();

            Console.WriteLine("Nombre:");
            telefono.Nombre = Console.ReadLine();
            Console.WriteLine("Precio:");
            telefono.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Número de Serie:");
            telefono.NumeroSerie = Console.ReadLine();
            Console.WriteLine("Marca:");
            telefono.Marca = Console.ReadLine();
            Console.WriteLine("Sistema Operativo:");
            telefono.SistemaOperativo = Console.ReadLine();

            Console.WriteLine("Información del televisor:");
            televisor.MostrarInformacion();
            televisor.MostrarInformacionAdicional();

            Console.WriteLine("Información del teléfono:");
            telefono.MostrarInformacion();
            telefono.MostrarInformacionAdicional();

            Console.ReadLine();
        }
    }
}
