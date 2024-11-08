using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
     //   When row size is fixed, but col size is unknown or different, then we can use Jagged array

     //Jagged array also called as an array of arrays

        static void Main(string[] args)
        {
            //Jagged Array
            int[][] jarr = new int[4][];

            jarr[0] = new int[] {1,2,3,4};
            jarr[1] = new int[] {5,6,7,8,9};
            jarr[2] = new int[] {99,88};
            jarr[3] = new int[] {50};

            //using for loop
            for(int i = 0; i < jarr.Length; i++)
            {
                for(int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write($"jarr[{i},{j}] = {jarr[i][j]}  ");
                }
                Console.WriteLine();
            }

            //Using foreach loop
            Console.WriteLine("Using foreach loop");
            foreach (int[] col in jarr) 
            { 
                foreach(int i in col)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }


            //Accept From user
            int[][] jarr1 = new int[4][];

            jarr1[0]=new int[4];
            jarr1[1]=new int[2];
            jarr1[2]=new int[3];
            jarr1[3]=new int[5];

            
            //Loop for accept value
            Console.WriteLine("Enter jagged array element");
            for (int i = 0; i < jarr1.Length; i++) 
            {
                Console.WriteLine($"Enter the jarr1[{i}] index element :");
                for (int j = 0; j < jarr1[i].Length; j++)
                {
                    jarr1[i][j]=Convert.ToInt32(Console.ReadLine());
                }
            }

            //Loop for print element
            for (int i = 0; i < jarr1.Length; i++)
            {
                for (int j = 0; j < jarr1[i].Length; j++)
                {
                    Console.Write($"{jarr1[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
