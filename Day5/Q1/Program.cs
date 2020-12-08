using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Employee
    {
        public int EmpNo;
        public string Name;
        public double Salary;
        public Employee()
        {

        }
       

        public void GetEmployee()
        {
            Console.WriteLine("enter employee NO ======> ");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee Name =====>");
            Name = Console.ReadLine();
            Console.WriteLine("Enter employee Salary =====>");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayEmployee()
        {

            Console.WriteLine( EmpNo+" "+Name+" "+Salary);
           
        }

       
    }

    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter No Of Employee");
            int size = Convert.ToInt32(Console.ReadLine());

            Employee[] E = new Employee[size];

            for (int i = 0; i < size; i++)
            {
               
                E[i] = new Employee();
                E[i].GetEmployee();
                
            }
            Console.ReadLine();
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("employee details of Employee No ="+i);
                E[i].DisplayEmployee();
            }
            Console.ReadLine();

            // Console.WriteLine("employee With highest Salary  ===>");

            //Employee maxEmp = E[0];
            //for(int i = 0; i < size; i++)
            //{

            //    if (E[i].Salary > maxEmp.Salary)
            //    {
            //        maxEmp = E[i];
            //        maxEmp.DisplayEmployee();

            //    }      
            //}

            Console.WriteLine("employee with highest salary =>");
            double temp = 0;
            for (int i = 0; i < size; i++)
            {

                if (E[i].Salary > temp)
                {
                    temp = E[i].Salary;


                }

            }


            Console.WriteLine("highest salary = " + temp);
            Employee details;
            for (int i = 0; i < size; i++)
            {
                details = E[i];
                if (temp == details.Salary)
                {
                    Console.WriteLine();
                    Console.WriteLine("highest salary employee details ===>");
                    Console.WriteLine("Employee number = " + details.EmpNo);
                    Console.WriteLine("Employee name = " + details.Name);
                    Console.WriteLine("Employee Salary = " + details.Salary);
                }
            }
            Console.ReadLine();

            Console.WriteLine("enter emp no tp search emp detail");
            int empno = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                details = E[i];
                if (empno == details.EmpNo)
                {
                    Console.WriteLine("Employee number = " + details.EmpNo);
                    Console.WriteLine("Employee name = " + details.Name);
                    Console.WriteLine("Employee Salary = " + details.Salary);
                }
            }

            Console.ReadLine();
        }
    }
}
