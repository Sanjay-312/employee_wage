using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace CalculateEmpWages
{
    internal class Program
    {
        public const int is_full_time = 1;

        public const int is_part_time = 2;

        public const int wage_per_hour = 20;

        public const int no_of_days_in_month = 20;
        static void Main(string[] args)
        {
            int total_wage = 0;

            int total_wage_per_day = 0;

            int total_hours_per_day = 0;

            for (int day=1;day<=no_of_days_in_month;day++)
            {
                Random random = new Random();

                int emp_check = random.Next(0, 3);

                switch (emp_check)
                {
                    case is_full_time:
                        total_hours_per_day = 8;
                        break;
                    case is_part_time:
                        total_hours_per_day = 4;
                        break;
                    default:
                        total_hours_per_day = 0;
                        break;

                }

                total_wage_per_day = wage_per_hour * total_hours_per_day;

                total_wage += total_wage_per_day;

                Console.WriteLine("total wage per day " + day + " is : " + total_wage_per_day);
            
            }

            Console.WriteLine("employee wage for 20 days : " + total_wage);

        }
    }
}