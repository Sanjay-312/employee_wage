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
        static void Main(string[] args)
        {
            int total_wage = 0;

            int total_hours_per_day = 0;

            Random random=new Random();

            int emp_check=random.Next(0,3);

            switch (emp_check)
            {
                case is_full_time:
                    total_hours_per_day = 8;
                    break;
                case is_part_time:
                    total_hours_per_day = 4;
                    break;
                default:
                    total_hours_per_day=0;
                    break;
            
            }

           total_wage = wage_per_hour * total_hours_per_day;

            Console.WriteLine("employee wage : "+total_wage);


        }
    }
}