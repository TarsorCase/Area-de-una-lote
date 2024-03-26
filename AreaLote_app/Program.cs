using System;

namespace MRUAConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule de precio de se lote");
            Console.Write("Ingrese el ancho de su lote: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el largo de su lote: ");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el precio por metro cuadrado: ");
            double metro = Convert.ToDouble(Console.ReadLine());

            double area = ancho * largo;
            double precio = area * metro;
            Console.WriteLine($"El area de su lote es de: {area} m^2");
            Console.WriteLine($"El precio de su lote seria de: {precio} $"
);
        }
    }
}
