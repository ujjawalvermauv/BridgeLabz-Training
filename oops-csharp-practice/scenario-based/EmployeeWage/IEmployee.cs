using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal interface IEmployee
    {
        void CheckAttendance();//uc1
        void CalculateDailyWage(); //uc2
        void AddPartTimeEmployee(); //uc3
        void CalculateMonthlyWage();   // uc4
        void CalculateWageWithLimit(); //uc5

    }
}