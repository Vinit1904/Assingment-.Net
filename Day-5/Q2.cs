using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3_Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Batches");
            int batchNo = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[batchNo][];
            for (int i=0;i<batchNo;i++)
            {
                Console.Write("Enter No of Student in Batch {0} : ", i);
                //Console.WriteLine("Enter No of Student in Batch {i}",i);
                int student = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[student];

                for (int j=0;j<student;j++)
                {
                    Console.WriteLine("Enter Marks of batch {0} studentNo {1} :",i,j);
                    int marks = Convert.ToInt32(Console.ReadLine());
                    arr[i][j] = marks;

                }

            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine("Batch No {0}",i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Marks of Student No {1} in batch {0} ", i,j);
                    Console.WriteLine(arr[i][j]);
                }
            }


            Console.ReadLine();
        }
    }
}
