using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 12, 7, 18, 9, 3, 2, 6, 15, 1};

            for (int i = 0; i < A.Length; i++)
            {
                int min = i;
                for (int j = i + 1; i < A.Length; i++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }
                //TODO: разменете елементите от масива с индекси min и i
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }

        }
    }
}
