using System;

namespace nesesyrdi
{
    class Program
    {
        static void Main(string[] args)
        {
            int BOARD_SIZE = 56;
            int[] board = new int[BOARD_SIZE];          //игралното поле
            int[] helpCounter = new int[BOARD_SIZE];    //огледален помощен масив съдържащ броя пулове в съответното квадратче

            System.Console.WriteLine("Въведете броя играчи: ");
            int playersCount = int.Parse(Console.ReadLine());

            int[] freePuls = new int[playersCount]; //брой невзети пулове за всеки играч
            int[] finishedPuls = new int[playersCount]; //брой завършили пулове за всеки играч

            int playerTurn = 1; //номер на поредния играч, който трябва да направи своя ход може да се изменя от 1 до playersCount
            bool isGameOver = true;


            while(!isGameOver)
            {
                //TODO: изчертай играта
                DrawGame(board, helpCounter);
                //TODO: играч с номер {playerTurn} хвърля зарче и прави своя ход
                if(finishedPuls[playerTurn - 1] == 4)
                {
                    System.Console.WriteLine("Player {0} wins !", playerTurn);
                    isGameOver = true;
                }


                //прехвърляме реда на средващия играч, увеличавайки playerTurn с 1
            }

            Console.ReadKey();
        }

        static void DrawGame(int[] board, int[] helpCounter)
        {
            
        } 
    }
}
