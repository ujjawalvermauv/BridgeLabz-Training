using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    sealed class EmployeeMenu
    {

        private readonly IEmployee employeeService;

        public EmployeeMenu()
        {
            employeeService = new EmployeeUtilityImpl();
        }
        public void Choices()
        {
            int choice;

            do
            {
                Console.WriteLine("\n==== Employee Wage Computation ====");
                Console.WriteLine("1. UC1 - Check Attendance");
                Console.WriteLine("2. UC2 - Calculate Daily Wage");
                Console.WriteLine("3. UC3 - Part Time Employee Wage");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employeeService.CheckAttendance();
                        break;
                    case 2:
                        employeeService.CalculateDailyWage();
                        break;
                    case 3:
                        employeeService.AddPartTimeEmployee();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 0);

        }
    }

}