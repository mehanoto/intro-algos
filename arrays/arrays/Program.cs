using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 5, 7, -1};
            int min = arr[0]; //помощна променлива, която пази стойността на текущо откритата минимална стойност
            int max = arr[0]; //помощна променлива, която пази стойността на текущо откритата максимална стойност
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) 
                {
                    min = arr[i];  
                }

                if (arr[i] > max) 
                {
                    max = arr[i];
                }
            }

            Console.Write("Min = {0}, Max = {1}", min, max);

            //Повторение на алгоритъма отгоре, само че този път ще пазим индекси вместо стойности
            int minIndex = 0; //помощна променлива, която пази индекса на текущо откритата минимална стойност
            int maxIndex = 0; //помощна променлива, която пази индекса на текущо откритата максимална стойност
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }

                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            Console.Write("MinIndex = {0}, MaxIndex = {1}", minIndex, maxIndex);


            //намиране на сумата/средната стойност на елементите на масива
            double sum = 0, avrg;
            for (int i = 0; i < arr.Length; i++)
            {
                //sum = sum + arr[i];
                sum += arr[i];
            }
            avrg = sum / arr.Length;

            Console.Write("Sum = {0}, Avrg = {1}", sum, avrg);
        }
    }
}
