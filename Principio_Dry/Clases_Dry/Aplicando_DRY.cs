using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Dry.Clases_Dry
{
    internal class Aplicando_DRY
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione el tipo de empleado:");
            Console.WriteLine("1. Empleado a tiempo completo");
            Console.WriteLine("2. Empleado a tiempo parcial");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.WriteLine("Ingrese el salario base del empleado a tiempo completo:");
                decimal baseSalary = decimal.Parse(Console.ReadLine()!);
                Console.WriteLine($"El salario calculado para el empleado a tiempo completo es: {CalculateSalaryForFullTime(baseSalary)}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Ingrese la tarifa por hora del empleado a tiempo parcial:");
                decimal hourlyRate = decimal.Parse(Console.ReadLine()!);
                Console.WriteLine("Ingrese las horas trabajadas por el empleado a tiempo parcial:");
                int hoursWorked = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"El salario calculado para el empleado a tiempo parcial es: {CalculateSalaryForPartTime(hourlyRate, hoursWorked)}");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }

        }
        static decimal CalculateSalaryForFullTime(decimal baseSalary)
        {
            CalculateBonusAndTax(baseSalary, out decimal bonus, out decimal tax);
            return baseSalary - tax + bonus;
        }
        static decimal CalculateSalaryForPartTime(decimal hourlyRate, int hoursWorked)
        {
            decimal salary = hourlyRate * hoursWorked;
            CalculateBonusAndTax(salary, out decimal bonus, out decimal tax);

            return salary - tax + bonus;
        }
        static void CalculateBonusAndTax(decimal salary, out decimal bonus, out decimal tax)
        {
            tax = salary * 0.18m;
            bonus = salary * 0.05m;
        }
    }
}
