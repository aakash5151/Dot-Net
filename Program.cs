using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleInterest
            Func<decimal, decimal, decimal,decimal> f1 = (p, n, r) => (p * n * r) / 100;
            Console.WriteLine("simple interest : "+f1(1000,2,2));
            Console.WriteLine();

            //IsGreater
            Func<int, int,bool> f2 = (a, b) => a > b;
            Console.WriteLine("IsGreater : "+f2(10,20));
            Console.WriteLine();

            //basic Salary
            Employee e = new Employee();
            //Func<Employee, decimal> f3 = emp => emp.basicSalary(e);
            //Console.WriteLine("basic salary is : "+f3(e));
            Func<Employee, decimal> f3 = emp => emp.BASIC_SALARY;
            Console.WriteLine("basic salary is : " + f3(e));
            Console.WriteLine();


            //IsEven
            Predicate<int> p1 = x => x % 2 == 0;
            Console.WriteLine("IsEven : "+p1(8));
             Console.WriteLine();

            //Func<Employee, bool> f4 = emp => emp.IsSalaryGreaterthan10000(e);
            //Console.WriteLine("is salary greater than 10000 : "+f4(e));
            //Console.WriteLine();

            Predicate<Employee> f4 = emp => emp.BASIC_SALARY > 10000;
            Console.WriteLine("is salary greater than 10000 : "+f4(e));
            Console.WriteLine();



        }
    }
    public class Employee
    {
        public decimal getBasic = 11000;

           public decimal BASIC_SALARY
        {

            set
            {
                getBasic = value;
            }
            get
            {
                return getBasic;
            }
        }


        //public decimal GetBasic = 11000;
        
        //public  decimal basicSalary(Employee e)
        //{
        //    return e.GetBasic;
        //}

        //public bool IsSalaryGreaterthan10000(Employee e)
        //{
        //    if (e.GetBasic > 10000)
        //        return true;
        //    else
        //        return false;
        //}
    }
}
