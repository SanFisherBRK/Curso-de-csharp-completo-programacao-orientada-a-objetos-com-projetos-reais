using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioDoCurso.Entities.Enums;
using ExercicioDoCurso.Entities;

namespace ExercicioDoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CI);

            Department dept = new Department(deptName);
            Worker Worker = new Worker(name, level, baseSalary, dept);
            Console.WriteLine();

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CI);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                Worker.AddContract(contract);
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            //Corta os dois digitos do mês e cola na variavel month
            int month = int.Parse(monthAndYear.Substring(0, 2));

            //Corta os digitos do ano do 3 em diante e cola na variavel year
            int year = int.Parse(monthAndYear.Substring(3));

            //Imprimindo na tela
            Console.WriteLine("Name " + Worker.Name);
            Console.WriteLine("Department " + Worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + Worker.Income(year, month).ToString("F2", CI));
        }
    }
}
