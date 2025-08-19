using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Kiss.Clases_Kiss
{
    internal class Aplicando_KISS
    {

        static void Main(string[] args)
        {
            CalculateTotal();
        }

        static void CalculateTotal()
        {
            Console.WriteLine("Ingrese los precios de los platos (separados por comas): ");
            string[] partes = Console.ReadLine()!.Split(',');

            decimal subtotal = 0;
            foreach (var parte in partes)
            {
                subtotal += decimal.Parse(parte);
            }

            Console.WriteLine("¿Propina personalizada? (s/n): ");
            decimal propina = 0.10m;
            if (Console.ReadLine()!.ToLower() == "s")
            {
                Console.WriteLine("Total a pagar: " + (subtotal + subtotal * propina));
            }
            else
            {
                Console.WriteLine("Total a pagar: " + (subtotal + subtotal * propina / 100));
            }

           
        }
    }
}
