using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Q1
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> di = new Dictionary<int, Employee>();
            char choice = 'y';
            while (choice == 'y')
            {
                Employee.insertEmployee(di);
                Console.Write("Do you Want to continue type (y/n) : ");
                choice = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine();

            Employee.empSearch(di);

            Console.WriteLine();
            Console.WriteLine();

            Employee.highSalary(di);

            Console.WriteLine();
            Console.WriteLine();

            Employee.nthEmpSearch(di);

            
            Console.ReadLine();

        }

    }


    class Employee
    {
        private int empId;

        private string empName;
        private decimal empSal;
        public static int empKey = 0;
        public int EmpId
        {
            set 
            { 
                if (value > 0) 
                    empId = value; 
                else 
                    Console.WriteLine("Enter Valid empId"); 
            }

            get 
            { 
                return empId; 
            }
        }
        public string EmpName
        {
            set 
            {
                if
                    (value == null) 
                    Console.WriteLine("Enter Valid empName"); 
                else 
                    empName = value; }
            get 
            { 
                return empName; 
            }
        }
        public decimal EmpSal
        {
            set 
            { 
                if (value < 10000) 
                    Console.WriteLine("Enter valid Emp sal "); 
                else 
                    empSal = value; }
            get 
            { 
                return empSal; 
            }
        }

        public Employee(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }

        public static void insertEmployee(Dictionary<int, Employee> di)
        {

         
            Console.Write("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            string empName = Console.ReadLine();
            Console.Write("Enter Employee Sal : ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());
            di.Add(++empKey, new Employee(empId, empName, empSal));
        }

        public static void highSalary(Dictionary<int, Employee> di)
        {

            decimal max = 0;
            foreach (KeyValuePair<int, Employee> kvp1 in di)
            {
                if (kvp1.Value.empSal > max)
                {
                    max = kvp1.Value.empSal;
                }

            }
            Console.WriteLine( "highest salary ="+max);

           
            foreach(KeyValuePair<int,Employee> kvp2 in di)
            {

                if (kvp2.Value.empSal == max)
                {
                    Console.WriteLine(kvp2.Key + " :==> " + kvp2.Value.EmpId + "  " + "  " + kvp2.Value.EmpName + "  " + kvp2.Value.EmpSal);
                }
            }
        }
        public static void empSearch(Dictionary<int, Employee> di)
        {
            Console.Write("Enter the Employee Number to search : ");
            int Searchid = Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<int, Employee> kvp in di)
            {
                if (Searchid == kvp.Value.EmpId)
                    Console.WriteLine(kvp.Key + " :==> " + kvp.Value.EmpId + "  " + "  " + kvp.Value.EmpName + "  " + kvp.Value.EmpSal);

            }
        }

        public static void nthEmpSearch(Dictionary<int, Employee> di)
        {
            Console.WriteLine("Enter the nth no of employee:");
            int SearchNth = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            foreach(KeyValuePair<int,Employee> kvp3 in di)
            {
                if (SearchNth == count)
                {
                    Console.WriteLine(kvp3.Key + " :==> " + kvp3.Value.EmpId + "  " + "  " + kvp3.Value.EmpName + "  " + kvp3.Value.EmpSal);
                }
                count++;
            }
        }
    }
}
