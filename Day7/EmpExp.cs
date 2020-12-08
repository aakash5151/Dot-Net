using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpException
{
    class EmpExp
    {
        static void Main(string[] args)
        {

            try
            {

                Employee1 e1 = new Employee1("Amol", 12000, 1);
                Console.WriteLine("Empid: " + e1.EMPNO + ", Name: " + e1.NAME + ", Basic salary: " + e1.BASIC + ", Dept No: " + e1.DEPTNO + ", Net salary: " + e1.GetNetSalary());
                Console.ReadLine();
                Employee1 e2 = new Employee1("Amol", 25000);
                Console.WriteLine("Empid: " + e2.EMPNO + ", Name: " + e2.NAME + ", Basic salary: " + e2.BASIC + ", Net salary: " + e2.GetNetSalary());
                Console.ReadLine();
                Employee1 e3 = new Employee1("", 60);
                Console.WriteLine("Empid: " + e3.EMPNO + ", Name: " + e3.NAME + ", Basic salary: " + e3.BASIC + ", Net salary: " + e3.GetNetSalary());
                Console.ReadLine();
                Employee1 e4 = new Employee1();
                Console.WriteLine("Empid: " + e4.EMPNO + ", Net salary: " + e4.GetNetSalary());
                Console.ReadLine();


                Console.WriteLine("Empid: " + e4.EMPNO + ", Net salary: " + e4.GetNetSalary());
                Console.ReadLine();

                Console.WriteLine("Empid: " + e3.EMPNO + ", Name: " + e3.NAME + ", Basic salary: " + e3.BASIC + ", Net salary: " + e3.GetNetSalary());
                Console.ReadLine();

                Console.WriteLine("Empid: " + e2.EMPNO + ", Name: " + e2.NAME + ", Basic salary: " + e2.BASIC + ", Net salary: " + e2.GetNetSalary());
                Console.ReadLine();

                Console.WriteLine("Empid: " + e1.EMPNO + ", Name: " + e1.NAME + ", Basic salary: " + e1.BASIC + ", Dept No: " + e1.DEPTNO + ", Net salary: " + e1.GetNetSalary());
                Console.ReadLine();
            }
            catch (InvalidEmpNameException ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    Employee1 e3 = new Employee1("myname", 15000);
                    Console.WriteLine("Empid: " + e3.EMPNO + ", Name: " + e3.NAME + ", Basic salary: " + e3.BASIC + ", Net salary: " + e3.GetNetSalary());
                }
                catch (InvalidEmpNameException exName)
                {

                    Console.WriteLine(exName.Message);
                }
                catch (InvalidEmpBasicException exBAsic)
                {
                    Console.WriteLine(exBAsic.Message);
                }
                catch (InvalidEmpDepNoException exDepNo)
                {
                    Console.WriteLine(exDepNo.Message);
                }

            }
            catch (InvalidEmpBasicException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidEmpDepNoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }

    class Employee1
    {
        private string Name;
        private static int EmpNo;
        private decimal Basic;
        private short DeptNo;

        //public static int counter;

        #region Constructors
        public Employee1()
        {
            EmpNo++;
            this.EMPNO += EmpNo;
        }
        public Employee1(string Name, decimal Basic, short DeptNo)
        {
            EmpNo++;
            this.EMPNO += EmpNo;
            this.NAME = Name;
            this.BASIC = Basic;
            this.DEPTNO = DeptNo;
        }
        public Employee1(string Name, decimal Basic)
        {
            EmpNo++;
            this.EMPNO += EmpNo;
            this.NAME = Name;
            this.BASIC = Basic;
        }
        public Employee1(string Name)
        {
            EmpNo++;
            this.EMPNO += EmpNo;
            this.NAME = Name;
        }
        #endregion

        #region Validations
        public string NAME
        {
            set
            {
                if (value != "")
                {

                    Name = value;
                }
                //Console.WriteLine("Name should not be empty");

                else
                {
                    Exception ex = new InvalidEmpNameException("Name should not be empty");

                    throw ex;
                }


            }
            get { return Name; }
        }

        public int EMPNO
        {
            get;
        }
        public decimal BASIC
        {
            set
            {
                if (value >= 10000 && value <= 50000)
                    Basic = value;
                else
                {
                    //Console.WriteLine("Enter valid basic");
                    Exception ex = new InvalidEmpBasicException("Enter valid basic");
                    throw ex;
                }

            }
            get { return Basic; }
        }

        public short DEPTNO
        {
            set
            {
                if (value >= 0)
                    DeptNo = value;
                else
                {
                    // Console.WriteLine("Enter valid Dept no");
                    Exception ex = new InvalidEmpDepNoException("Enter valid Dept no");
                    throw ex;
                }


            }
            get { return DeptNo; }
        }
        #endregion

        public decimal GetNetSalary()
        {
            if (BASIC >= 10000 && BASIC <= 50000)
            {
                decimal netSal = BASIC + 1000;
                return netSal;
            }
            return BASIC;


        }


    }
    public class InvalidEmpNameException : ApplicationException
    {
        public InvalidEmpNameException(string message) : base(message)
        {

        }

    }
    public class InvalidEmpBasicException : ApplicationException
    {
        public InvalidEmpBasicException(string message) : base(message)
        {

        }

    }
    public class InvalidEmpDepNoException : ApplicationException
    {
        public InvalidEmpDepNoException(string message) : base(message)
        {

        }

    }
}
