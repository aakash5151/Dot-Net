using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter no of batches");
            int batch = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[batch][];
            for(int i = 0; i < batch; i++)
            {
                Console.WriteLine("enter the batch size");
                int batchSize = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[batchSize];
            }
           
           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter marks for students [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("marks of students {0},{1} is {2}  ",i,j,arr[i][j]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

