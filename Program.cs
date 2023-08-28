using System;

namespace CalculateEmpWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int is_present = 1;

            Random random=new Random();

            int emp_check=random.Next(0,2);

            int wage_per_hour = 20;

            int total_wage = 0;
            int total_hours_per_day = 0;

            if (emp_check==is_present)
            {
                total_hours_per_day = 8;
            }
            else
            {
                total_hours_per_day = 0;
            }
            total_wage = wage_per_hour * total_hours_per_day;

            Console.WriteLine("employee salary per day is : "+total_wage);


        }
    }
}