using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        int Present = 0;
        public void Attendance()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}

