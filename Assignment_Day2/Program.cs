using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Aakash", 123465, 10);
            Console.WriteLine(Employee.EmpNo + " " + o1.NAME + " " + o1.BASIC + " " + o1.DEPTNO + " " + o1.GetNetSalary());
            Employee o2 = new Employee("Mahesh", 123465);
            Console.WriteLine(Employee.EmpNo + " " + o2.NAME + " " + o2.BASIC + " " + o2.DEPTNO);
            Employee o3 = new Employee("Shubham");
            Console.WriteLine(Employee.EmpNo + " " + o3.NAME);
            Employee o4 = new Employee();
            Console.WriteLine(Employee.EmpNo);

            //Employee o1 = new Employee();
            //Employee o2 = new Employee();
            //Employee o3 = new Employee();
            //Console.WriteLine(Employee.EmpNo);
            //Console.WriteLine(Employee.EmpNo);
            //Console.WriteLine(Employee.EmpNo);
            Console.ReadLine();
        }
    }

    public class Employee
    {
        private String Name;
        public static int EmpNo;
        private decimal Basic;
        private short DeptNo;


        public Employee(String name="null",decimal basic=0,short DeptNo = 0)
        {
            EmpNo++;
            NAME = name;
            BASIC = basic;
            DEPTNO = DeptNo;

        }
       

        public String NAME
        {
            set
            {
                if (value != "")
                        Name = value;
                else
                    Console.WriteLine("please enter valid Name");

            }
            get
            {

                return Name;
            }


        }
        public decimal BASIC
        {
            set
            {
                if (value > 10000 && value < 50000)
                    Basic = value;
                else
                    Console.WriteLine("please enter salary within range");

            }
            get
            {
                return Basic;
            }
            

        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("enter valid Deptno");
            }
            get
            {
                return DeptNo;
            }

        }


        public decimal GetNetSalary()
        {
            if (BASIC >= 10000 && BASIC <= 50000)
            {
                decimal gross = BASIC + 1000;
                return gross;
            }
            return BASIC;


        }


    }
}
