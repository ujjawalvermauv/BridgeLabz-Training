using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private readonly int _wagePerHour = 20;
        private readonly int _fullDayHour = 8;
        private double _dailyWage;
        private double _dailyWage;
        private readonly int _partTimeHour = 8;
        private readonly int _workingDays = 20;
        private readonly int _maxHours = 100;
        private Random random = new Random();
        private Employee[] employees = new Employee[100];
        int count = 0;

        // UC1 - Check Employee is Present or Absent
        public void CheckAttendance()
        {
            int attendance = random.Next(0, 2);

            if (attendance == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        //UC2 - Check Employee daily Wage
        public void CalculateDailyWage()
        {

            _dailyWage = _fullDayHour * _wagePerHour;
            Console.WriteLine("Employee Daily Wage : " + _dailyWage);
        }
        public void AddPartTimeEmployee() //UC3 - Part Time Employee Wage
        {
            int empType = random.Next(0, 3); // 0-Absent, 1-FullTime, 2-PartTime
            int hours = 0;

            switch (empType)
            {
                case 1:
                    Console.WriteLine("Full Time Employee");
                    hours = _fullDayHour;
                    break;

                case 2:
                    Console.WriteLine("Part Time Employee");
                    hours = _partTimeHour;
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    hours = 0;
                    break;
            }

            int wage = hours * _wagePerHour;
            Console.WriteLine("Wage: " + wage);
        }
        // UC4 - Calculate Wages for a Month (20 Days)
        public void CalculateMonthlyWage()
        {
            int totalWage = 0;

            for (int day = 1; day <= _workingDays; day++)
            {
                int empType = random.Next(0, 3);
                int hours = 0;

                switch (empType)
                {
                    case 1:
                        hours = _fullDayHour;
                        break;
                    case 2:
                        hours = _partTimeHour;
                        break;
                    default:
                        hours = 0;
                        break;
                }

                totalWage += hours * _wagePerHour;
            }

            Console.WriteLine("Monthly Wage (20 Days): " + totalWage);
        }
        // UC5 - Calculate Wage till 100 Hours or 20 Days
        public void CalculateWageWithLimit()
        {
            int totalHours = 0;
            int totalDays = 0;
            int totalWage = 0;

            while (totalHours < _maxHours && totalDays < _workingDays)
            {
                totalDays++;
                int empType = random.Next(0, 3);
                int hours = 0;

                switch (empType)
                {
                    case 1:
                        hours = _fullDayHour;
                        break;
                    case 2:
                        hours = _partTimeHour;
                        break;
                    default:
                        hours = 0;
                        break;
                }

                totalHours += hours;
                totalWage += hours * _wagePerHour;
            }

            Console.WriteLine("Total Days: " + totalDays);
            Console.WriteLine("Total Hours: " + totalHours);
            Console.WriteLine("Total Wage with Condition: " + totalWage);
        }


        public void add() //uc6 - Add Employee Details
        {
            Employee emp = new Employee();

            Console.Write("Enter Employee Id: ");
            emp.EmployeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine();

            employees[count] = emp;
            count++;

            Console.WriteLine("Employee Added Successfully!");
        }
        public void GetEmployees() //uc6 - Get Employee Details
        {
            Console.WriteLine("Enter employee id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(employees[id].ToString());

        }
    }
}

