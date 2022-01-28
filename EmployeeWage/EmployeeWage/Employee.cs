using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int FullTimePresent = 0, PartTimePresent = 1,WagePerHr = 20;
        public void PartTimeWage()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            int Emphrs = 0;
            int Empwage = 0;
            switch (result)
            {
                case FullTimePresent:
                     Emphrs = 8;
                    break;
                case PartTimePresent:

                    Emphrs = 4;
                    break;
                default:
                    {
                        Emphrs = 0;
                        break;
                    }
                    Empwage = Emphrs * WagePerHr;
                    Console.WriteLine("Emp Wage: " + Empwage);
                    Console.ReadLine();
            }
        }
    }
}
