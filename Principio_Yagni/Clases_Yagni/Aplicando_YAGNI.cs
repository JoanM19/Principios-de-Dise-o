using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Yagni.Clases_Yagni
{
    internal class Aplicando_YAGNI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");

            int choice = int.Parse(Console.ReadLine()!);
            if (choice == 1)
            {
                Console.WriteLine("Ingrese el nombre del producto: ");
                string productName = Console.ReadLine()!;
                Console.WriteLine("Ingrese el precio del producto: ");
                decimal productPrice = decimal.Parse(Console.ReadLine()!);
                AddProduct(productName, productPrice);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Ingrese el ID del producto a eliminar: ");
                int productId = int.Parse(Console.ReadLine()!);
                DeleteProduct(productId);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }

        }
        static void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Product {name} added with price {price}. ");
        }
        static void DeleteProduct(int ProductId)
        {
            Console.WriteLine($"Product {ProductId} deleted.");
        }
        //public void GenerateProductReport()
        //{
        //    Console.WriteLine("Generating product report.");
        //}
    }
}
