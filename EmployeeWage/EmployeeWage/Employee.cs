using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int FullTimePresent = 0, PartTimePresent = 1, PartTimeHrs=4, WagePerHr = 20, Emphrs = 0;
        public void PartTimeWage()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == 0)
            {
                Console.WriteLine("Employee is Present For Fulltime");
                int Emphrs = 8;
                int Totalwage = Emphrs * WagePerHr;
                Console.WriteLine("Wage is " + Totalwage);
            }
            else if (result == 1)
                {
                Console.WriteLine("Employee is Present For Part Time");
                int Emhrs = 4;
                int Totalwage = Emhrs * WagePerHr;
                Console.WriteLine("Wage is " + Totalwage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}

