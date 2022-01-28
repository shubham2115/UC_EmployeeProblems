using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int FullTimePresent = 0, PartTimePresent = 1, WagePerHr = 20, NumberOfWorkingDays = 20, MaxHrsInMonths = 100;
        public void MonthlyWage()
        {

            int Emphrs = 0, totalEmphrs = 0, TotaWorkingDays = 0;
            while (totalEmphrs<=MaxHrsInMonths && TotaWorkingDays<NumberOfWorkingDays)
            {
                TotaWorkingDays++;
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
                totalEmphrs += Emphrs;
                Console.WriteLine("Days:" +TotaWorkingDays+ "Emphrs:" +Emphrs);
            }
            int totalEmpwage = totalEmphrs * WagePerHr;
                Console.WriteLine("Total Emp Wage: " + totalEmpwage);
                Console.ReadLine();
        }
    }
}
