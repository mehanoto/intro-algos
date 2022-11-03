using System;

namespace hanoi
{
    class Program
    {

        public static void SolveHanoi(int n, char from, char to, char other) {

            if (n == 1)
            {
                Console.WriteLine("Move disk from " + from + " to " + to);
            }
            else 
            {
                SolveHanoi(n - 1, from, other, to);
                Console.WriteLine("Move disk from " + from + " to " + to);
                SolveHanoi(n - 1, other, to, from);
            }
        }

        static void Main(string[] args)
        {
            SolveHanoi(3, 'a', 'b', 'c');
            Console.ReadLine();
        }
    }
}
