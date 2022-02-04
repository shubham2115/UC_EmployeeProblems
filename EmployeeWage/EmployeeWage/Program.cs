// See https://aka.ms/new-console-template for more information

using EmployeeWage;
Employee dMart = new Employee();
dMart.empWageBuilderObject("TCS", 20, 2, 10);
 Employee reliance = new Employee();
reliance.empWageBuilderObject("Infosys", 10, 4, 20);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
reliance.computeEmpWage();
Console.WriteLine(reliance.toString());