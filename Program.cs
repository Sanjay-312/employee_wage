using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace CalculateEmpWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EmpWageBulderObject company_1 = new EmpWageBulderObject("D-mart",20,20,100);
            
            EmpWageBulderObject company_2=new EmpWageBulderObject("Jio",10,10,50);

            company_1.calculateWages();

            Console.WriteLine("---------------------------------------");

            Console.WriteLine(company_1.toString());
            Console.WriteLine("----------------------------------------");

            company_2.calculateWages();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(company_2.toString());
            Console.WriteLine("----------------------------------------");


        }
    }

    public class EmpWageBulderObject
    {
        public const int is_full_time = 1;

        public const int is_part_time = 2;

        private string company;
        private int wage_per_hour;
        private int no_of_working_days;
        private int max_hrs_in_month;
        private int total_wage = 0;

        public EmpWageBulderObject(string compnay,int wage_per_hour,int no_of_working_days,int max_hrs_in_month)
        {
            this.company = compnay;
            this.wage_per_hour = wage_per_hour;
            this.no_of_working_days = no_of_working_days;
            this.max_hrs_in_month = max_hrs_in_month;

        }
        public void calculateWages()
        {
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

            total_wage = emp_hours * wage_per_hour;

            Console.WriteLine("total emp wage : " + total_wage);
            

           
            

        }
        public string toString()
        {
            return "total emp wage for company " + this.company + " is " + this.total_wage;
        }
    }
}