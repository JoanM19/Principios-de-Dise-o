using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principi_Solid.Clases_Solid
{
    internal class Aplicando_Solid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Enviar Email");
            Console.WriteLine("2. Enviar SMS");

            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.WriteLine("Ingrese el email: ");
                string email = Console.ReadLine()!;
                Console.WriteLine("Ingrese el mensaje: ");
                string message = Console.ReadLine()!;
                SendEmail(email, message);
                LogNotification.LogNotification_Method(message);
            }
           else if(choice == 2)
            {
                Console.WriteLine("Ingrese el número de teléfono: ");
                string phoneNumber = Console.ReadLine()!;
                Console.WriteLine("Ingrese el mensaje: ");
                string message = Console.ReadLine()!;
                SendSMS(phoneNumber, message);
                LogNotification.LogNotification_Method(message);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
            

        }
        static void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending Email to {email}: {message}");

        }
        static void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
        }
       
    }
}
