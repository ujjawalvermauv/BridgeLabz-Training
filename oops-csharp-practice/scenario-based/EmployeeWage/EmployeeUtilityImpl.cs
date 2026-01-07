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
        private Random random = new Random();




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
    }
}