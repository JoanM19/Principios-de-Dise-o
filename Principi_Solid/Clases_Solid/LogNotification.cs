using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principi_Solid.Clases_Solid
{
    public class LogNotification
    {
        public static void LogNotification_Method(string message)
        {
            Console.WriteLine($"Logging notification: {message}");
        }
    }
}
