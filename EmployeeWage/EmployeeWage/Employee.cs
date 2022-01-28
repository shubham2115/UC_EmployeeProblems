using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int FullTimePresent = 0, PartTimePresent = 1, WagePerHr = 20, TotalWorkingDays = 20;
        public void MonthlyWage()
        {

            int Emphrs = 0, Empwage = 0, TotalEmpwage = 0;

            for (int day = 0; day < TotalWorkingDays; day++)
            {
                Random random = new Random();
                int result = random.Next(0, 3);
                switch (result)
                {
                    case FullTimePresent:
                        Emphrs = 8;
                        break;
                    case PartTimePresent:
                        Emphrs = 4;
                        break;
                    default:
                        Emphrs = 0;
                        break;
                }
                Empwage = Emphrs * WagePerHr;
                TotalEmpwage += Empwage;
                Console.WriteLine("Emp Wage: " + Empwage);
            }
            Console.WriteLine("Total Emp wage is:" +TotalEmpwage);

            
            Console.ReadLine();
        }
    }
}
