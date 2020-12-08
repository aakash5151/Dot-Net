using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Q2
    {
        static void Main()
        {
            Emp1[] arr = new Emp1[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter empno ");
                int EMPNO = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter salary");
                decimal SALARY = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Name ");
                string NAME = Console.ReadLine();
                arr[i] = new Emp1();
                arr[i].EMPNO = EMPNO;
                arr[i].SALARY = SALARY;
                arr[i].NAME = NAME; 
            }
            Console.WriteLine("array");
            foreach (Emp1 a in arr)
            {
                Console.WriteLine( a.EMPNO+" "+a.SALARY+" "+a.NAME);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<Emp1> l1 = arr.ToList<Emp1>();
            Console.WriteLine("List ");
            foreach (Emp1 l in l1)
            {
                Console.WriteLine(l.EMPNO+" "+l.SALARY+" "+l.NAME);
            }
            Console.ReadLine();
        }
    }

    public class Emp1
    {
       
        public int EMPNO
        {
            set; get;
        }
        public decimal SALARY
        {
            set; get;
        }

        public string NAME
        {
            set; get;
        }
    }
}
