using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicalexpression
{
    class Program
    {

        static int[][] X = {
                               new int[] {1, 4},
                               new int[] {},
                               new int[] {}
                           };

        static int N = 4;
        static bool[] values = new bool[N];
        
        static void Step(int i)
        {
            if (i == N)//гранично условие
            {
                if (Test()) 
                {
                    PrintSolution();
                }
            }
            else
            {
                values[i] = true;
                Step(i + 1);
                values[i] = false;
                Step(i + 1);
            }
        }

        //Този метод проверява дали логическият израз е удовлетворен 
        static bool Test()
        {
            //TODO: да се довърши метода
            return true;
        }

        static void PrintSolution()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("X{0} = {1}, ", i + 1, values[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Step(0);   
        }

    }
}
