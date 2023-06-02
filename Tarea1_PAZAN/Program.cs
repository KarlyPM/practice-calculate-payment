using System;

namespace Tarea1_PAZAN
{
    internal class Program
    {
        static double CalcularTotalAPagar(int cantHamburguesa, int cantPapas, int cantRefresco)
        {
            const double HAMBURGUESA = 4.50;
            const double PAPAS = 2.50;
            const double REFRESCO = 1.50;

            return cantHamburguesa * HAMBURGUESA + cantPapas * PAPAS + cantRefresco * REFRESCO;
        }

        static int PedirCantidadProducto(string producto)
        {
            Console.Write("Cantidad de " + producto + ": ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Comidas rapidas de Karla");
            Console.WriteLine("Ingrese la cantidad de cada producto");

            int cantHamburguesa = PedirCantidadProducto("Hamburguesas");
            int cantPapas = PedirCantidadProducto("Papas");
            int cantRefresco = PedirCantidadProducto("Refrescos");

            double totalAPagar = CalcularTotalAPagar(cantHamburguesa, cantPapas, cantRefresco);

            Console.WriteLine("Valor a pagar es: $" + totalAPagar);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }

    }
}
