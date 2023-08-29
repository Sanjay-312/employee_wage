using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace CalculateEmpWages
{
    internal class Program
    {
        public const int is_full_time = 1;

        public const int is_part_time = 2;

        public static int calculateWages(string company,int wage_per_hour,int no_of_working_days,int max_hrs_in_month)
        {
            int total_wage = 0;

            int total_hours_per_day = 0;

            int total_working_days = 0;

            int emp_hours = 0;

            while (emp_hours <= max_hrs_in_month && total_working_days < no_of_working_days)
            {
                total_working_days++;

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
                emp_hours += total_hours_per_day;

                Console.WriteLine("day " + total_working_days + " emp hrs : " + emp_hours);

            }
            Console.WriteLine("---------------------------------");

            total_wage = emp_hours * wage_per_hour;

            Console.WriteLine("total emp wage : " + total_wage);
            return total_wage;
        }
        static void Main(string[] args)
        {
            
            calculateWages("D-mart",20,20,100);
            Console.WriteLine("---------------------------------");
            calculateWages("Jio", 10, 20, 50);

        }
    }
}