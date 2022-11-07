using System;
using System.Text;

namespace nesesyrdi
{
    class Program
    {
        static void Main(string[] args)
        {
            int BOARD_SIZE = 56;
            int[] board = new int[BOARD_SIZE];          //игралното поле
            int[] helpCounter = new int[BOARD_SIZE];    //огледален помощен масив съдържащ броя пулове в съответното квадратче

            System.Console.WriteLine("Enter players number between [2, 4]: ");
            //TODO: Добавете валидация за броя играчи, ако не е в интервала [2, 4], трябва автоматично да ни подсети да въведем правилен брой и да ни даде възможност да въведем броя отново
            // int playersCount = int.Parse(Console.ReadLine());
            int playersCount = 4;

            int[] freePuls = new int[playersCount]; //брой невзети пулове за всеки играч
            int[] finishedPuls = new int[playersCount]; //брой завършили пулове за всеки играч

            int currentPlayer = 1; //номер на поредния играч, който трябва да направи своя ход може да се изменя от 1 до playersCount
            bool isGameOver = true;


            while(!isGameOver)
            {
                DrawGame(board, helpCounter);
                System.Console.WriteLine("Player {0}, press any key to roll a dice.", currentPlayer);
                //TODO: Направете така че играта да продължава чак след като е натиснат произволен клавиш
                int diceResult = RollDice();
                int activePuls = GetActivePuls(currentPlayer);
                MakeMove(currentPlayer, diceResult, activePuls);

                if(finishedPuls[currentPlayer - 1] == 4)
                {
                    System.Console.WriteLine("Player {0} wins !", currentPlayer);
                    isGameOver = true;
                }
                
                currentPlayer = GetNextPlayerTurn(currentPlayer, playersCount);
            }

            DrawGame(board, helpCounter);

            Console.ReadKey();
        }

        ///<summary>
        ///Прави ход според избора на играча, ако играча има повече от един активни пулове трябва да избере кой от тях да премести, също така ако е изкарал шестица, има избор 
        ///дали да извади нов пул тази логика се прави в този метод
        ///</summary>
        static int MakeMove(int player, int diceResult, int activePuls)
        {

            return -1;
        }
        ///<summary>
        ///Връща активните пулове за играча, който се предава като входен параметър {player}
        ///</summary>
        static int GetActivePuls(int player)
        {
            //TODO: Изчислете активните пулове за съответния играч
            return -1;
        }

        ///<summary>
        ///Връща произволно число в интервала [1..6]. 
        ///</summary>
        static int RollDice()
        {
            //TODO: потърсете в гугъл как се генерира произволно число от цял тип и попълнете метода
            return -1;
        }


        ///<summary>
        ///Приема един входен параметър, който представлява играчът който е наред. Трябва да върне като резултат следващия играч поред.
        ///</summary>
        static int GetNextPlayerTurn(int player, int players)
        {
            //TODO: Върнете реда на слеващия играч
            return -1;
        }

        static void DrawLine(int line, int[] board, int[] helpCounter, int middleLine)
        {
            const string EMPTY = "   ";
            int LAST_LINE = (middleLine - 1) * 2 + 1;
            StringBuilder spaceBuilder = new StringBuilder();
            int emptySquares = Math.Abs(middleLine - line);
            for (int i = 0; i < emptySquares; i++)
            {
                spaceBuilder.Append(EMPTY);
            }

            int rightIndx = line - 1;
            int leftIndx = (board.Length - rightIndx) % board.Length;

            StringBuilder middleSpaceBuilder = new StringBuilder();
            int middleSquares = 27 - Math.Abs(middleLine - line) * 2;
            for (int i = 0; i < middleSquares; i++)
            {
                middleSpaceBuilder.Append(EMPTY);
            }

            System.Console.Write(spaceBuilder.ToString());
            System.Console.Write(" {0} ", board[leftIndx]);
            if(rightIndx == leftIndx)
            {
                System.Console.WriteLine();
            }
            else
            {
                System.Console.Write(middleSpaceBuilder.ToString());
                System.Console.WriteLine(" {0} ", board[rightIndx]);
            }
        }

        static void DrawGame(int[] board, int[] helpCounter)
        {
            int LINES = (board.Length - 2) / 2 + 2;
            int MIDDLE_LINE = (LINES - 1) / 2 + 1;

            for (int line = 1; line <= LINES; line++)
            {
                DrawLine(line, board, helpCounter, MIDDLE_LINE);
            }
        } 
    }
}
