using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_full_day = 1;

            Random random = new Random();
            int day = random.Next(0, 2);

            if (day == is_full_day)
            {
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("The Employee is Absent ");
            }
        }
    }
}
