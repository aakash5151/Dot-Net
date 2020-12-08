using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
       

        static void Main()
        {
            int i = 0;
            Student[] s = new Student[5];
           
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("name of student =");
                string NAME = Console.ReadLine();
                Console.WriteLine("Rollno of Student =");
                int ROLLNO = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Marks of Student =");
                decimal MARKS = Convert.ToDecimal(Console.ReadLine());
                s[i] = new Student(NAME, ROLLNO, MARKS);
            }


            Console.ReadLine();

            for ( i = 0; i < 5; i++)
            {
                s[i].Display();
            }
            Console.ReadLine();
        }
    }

    public struct Student
    {
        private string Name;
        private int RollNo;
        private decimal Marks;

        public Student(string NAME,int ROLLNO,decimal MARKS)
        {
            this.Name = "noname";
            this.RollNo = 1;
            this.Marks = 1;
            this.NAME = NAME;
            this.ROLLNO = ROLLNO;
            this.MARKS = MARKS;
            
        }

        public string NAME
        {
            set
            {
                if(value != "")
                {
                    Name = value;
                }
                else
                {
                    Console.WriteLine("invalid name");
                }
            }
            get
            {
                return Name;
            }
        }

        public int ROLLNO
        {
            set
            {
                if (value > 0)
                {
                    RollNo = value;
                }
                else
                {
                    Console.WriteLine("wrong rollno");
                }
            }
            get
            {
                return RollNo;
            }
        }

        public decimal MARKS
        {
            set
            {
                if (value > 0)
                {
                    Marks = value;
                }
                else
                {
                    Console.WriteLine("invalid marks");
                }
            }
            get
            {
                return Marks;
            }
        }

        public void Display()
        {
            Console.WriteLine(Name+" "+RollNo+" "+Marks);
        }
    }
}
