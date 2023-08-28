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

            


            if (emp_check==is_present)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            

        }
    }
}