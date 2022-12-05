using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {

        /// <summary>
        /// Генерира масив от случайни цели числа с големина size
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        static int[] GenerateRandomArray(int size)
        {
            int[] result = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                result[i] = rnd.Next(-100, 100);
            }
            return result;
        }

        /// <summary>
        /// Създава нов масив от цели числа и компира информацията от source в новия, новият масив се връща като стойност
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        static int[] Copy(int[] source)
        {
            int[] result = new int[source.Length];
            //TODO: заменете долното копиране на елементи с for цикъл
            Array.Copy(source, result, source.Length);
            return result;
        }

        /// <summary>
        /// Създава масив от цели числа с големина size, като във всяка клетка записва като стойност индекса на клетката + 1. Новият масив се връща като резултат.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        static int[] GenerateAscending(int size)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }

        /// <summary>
        /// Създава масив от цели числа с големина size. Записват се такива стойности в масива, че да намаляват като стойнст, на първа позиция се записва големината на масива и всяко следващо число намалява с 1-ца.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        static int[] GenerateDescending(int size)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = size - i;
            }
            return result;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }


        static void SelectionSort(int[] array, bool asc)
        {
            if (asc) 
            { 
                SelectionSortAsc(array); 
            }
            else 
            {
                SelectionSortDesc(array);
            }
        }

        static void BubbleSort(int[] array, bool asc)
        {
            if (asc)
            {
                BubbleSortAsc(array);
            }
            else
            {
                BubbleSortDesc(array);
            }
        }

        static void BubbleSortAsc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(array, j, j + 1);
                }
            }
        }

        /// <summary>
        /// Сортира низходящо по метода на мехурчето
        /// </summary>
        /// <param name="array"></param>
        static void BubbleSortDesc(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    if(array[j - 1] < array[j])
                        Swap(array, j, j - 1);
                }
            }
        }

        /// <summary>
        /// Сортира низходящо по метода на прекия избор Selection sort
        /// </summary>
        /// <param name="array"></param>
        static void SelectionSortDesc(int[] array)
        {
            //TODO: Напишете метода по модел на SelectionSortDesc
        }

        static void SelectionSortAsc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                Swap(array, min, i);
            }
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        /// <summary>
        /// Отмества елемент с индекс position с определен брой позиции offset наляво, като съответно това същевременно премества цял блок от елементи надясно.
        /// </summary>
        /// <param name="array">масивът</param>
        /// <param name="position">индексът на позицията, която ще отместваме</param>
        /// <param name="offset">с колко позиции местим наляво</param>
        static void ShiftLeftArray(int[] array, int position, int offset)
        {
            if (position - offset < 0)//излизаме извън рамките на масива
            {
                throw new IndexOutOfRangeException("Out of range error");
            }

            for (int i = position; i > position - offset; i--)
            {
                Swap(array, i, i - 1);
            }
        }

        static void InsertionSortAsc(int[] array)
        { 
                
        }

        static int GetChoice()
        {
            Console.WriteLine("For Bubble sort press [1]");
            Console.WriteLine("For Selection sort [2]");
            Console.WriteLine("For Insertion sort press [3]");
            Console.WriteLine("For standard sort press[4]");
            Console.WriteLine("To exit press [5]");
            int choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 5)
            {
                Console.Write("Please enter number according to available choices!");
                choice = int.Parse(Console.ReadLine());
            }
            return choice;
        }

        static bool CompareArrays(int[] arr1, int[] arr2)
        {
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array size = ");
            int size = int.Parse(Console.ReadLine());

            int[] previousSorted = null; //копие на масива от предишното сортиране, ако сме сортирали няколко пъти
            int[] arr = GenerateRandomArray(size); //масивът който ще сортираме
            PrintArray(arr);

            while (true)
            {
                int choice = GetChoice();
                if (choice == 5)
                    break;
                Console.WriteLine("To sort ascending press a, for descending press d");
                string read = Console.ReadLine();
                bool ascending;
                if (read == "a")
                {
                    ascending = true;
                }
                else if(read == "d")
                {
                    ascending = false;
                }
                else 
                {
                    Console.WriteLine("Regarding this as ascending");
                    ascending = true;
                }

                switch (choice)
                {
                    case 1:
                        BubbleSort(arr, ascending);
                        break;
                    case 2:
                        SelectionSort(arr, ascending);
                        break;
                    case 3:
                        //InsertionSort(arr, ascending);
                        break;
                    case 4:
                        Array.Sort(arr);
                        break;
                }
                PrintArray(arr);

                if (previousSorted != null && CompareArrays(previousSorted, arr))
                {
                    Console.WriteLine("Same result !");
                }
                previousSorted = Copy(arr);
            }

        }
    }
}
