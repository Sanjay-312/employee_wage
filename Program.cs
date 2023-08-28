using System;

namespace CalculateEmpWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int is_full_time = 1;

            int is_part_time = 2;

            Random random=new Random();

            int emp_check=random.Next(0,3);

            int wage_per_hour = 20;

            int total_wage = 0;
            int total_hours_per_day = 0;

            if (emp_check==is_full_time)
            {
                total_hours_per_day = 8;
            }
            else if (emp_check==is_part_time)
            {
                total_hours_per_day = 4;
            }
            else
            {
                total_hours_per_day = 0;
            }
            total_wage = wage_per_hour * total_hours_per_day;

            Console.WriteLine("employee wage : "+total_wage);


        }
    }
}