using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Q3
    {
        static void Main()
        {
            List<Emp2> li = new List<Emp2>();
            li.Add(new Emp2 { EMPNO = 1 ,SALARY=400000,NAME="aakash"}) ;
            li.Add(new Emp2 { EMPNO = 2, SALARY = 600000, NAME = "mahesh" });

           
            object[] arr = li.ToArray();

            foreach (Emp2 e in arr)
            {
                Console.WriteLine(e.EMPNO + " " + e.SALARY+" "+e.NAME);
            }
            Console.ReadLine();
        }
    }

    public class Emp2
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
