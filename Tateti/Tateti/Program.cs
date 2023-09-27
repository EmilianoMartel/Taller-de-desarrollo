using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti
{
    class Program
    {
        //Const
        const string TITLE =
@"  _______          _______  ______   _______  _____ 
 |__   __| /\     |__   __||  ____| |__   __||_   _|
    | |   /  \       | |   | |__       | |     | |  
    | |  / /\ \      | |   |  __|      | |     | |  
    | | / ____ \     | |   | |____     | |    _| |_ 
    |_|/_/    \_\    |_|   |______|    |_|   |_____|
                                                    ";

        const string HUMAN_SIMBOL = "X";
        const string COMPUTER_SIMBOL = "0";
        const string BASIC_VALUE = " ";

        //Global variables
        static string[,] tableValues = new string[3, 3];
        static bool isHumanTurn = true;
        static int choose = 0;
        static string winner;
        static bool rePlay = true;
        static string actualOption = " ";
        static int actualY = 0;
        static int actualX = 0;
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (choose != 3)
            {
                Console.Clear();
                MainMenu();
                choose = MaxInputCheck(3);
                switch (choose)
                {
                    //GAME
                    case 1:
                        Console.Clear();
                        Game();
                        break;
                    //Instructions
                    case 2:
                        Instructions();
                        break;
                }
            }
        }

        //Functions

        //PressAnyKey
        static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue.");
            while (Console.KeyAvailable)
            {
                Console.ReadKey(intercept: true);
            }
            Console.ReadKey(intercept: true);
        }
        //Int check
        static int IntCheck()
        {
            int option = 0;
            bool validInput = false;

            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    option = result;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            } while (!validInput);

            return option;
        }
        //Check is over the number
        static int MaxInputCheck(int maxOption)
        {
            int answer = 0;
            answer = IntCheck();
            while (answer > maxOption || answer <= 0)
            {
                Console.WriteLine("Invalid input, please try again.");
                answer = IntCheck();
            }
            return answer;
        }
        //InputGameCheck
        static bool IsTakenSquare()
        {
            if (tableValues[actualX, actualY] == BASIC_VALUE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Convert string to int
        static void ConverterXandY(string input)
        {
            actualX = int.Parse(input[0].ToString());
            actualY = int.Parse(input[1].ToString());
        }
        //Check input values for square
        static void CheckInputSquare()
        {
            actualOption = Console.ReadLine();
            if (actualOption.Length != 2)
            {
                Console.WriteLine("The string must have exactly two characters.");
                Console.WriteLine("Try again.");
                CheckInputSquare();
            }
            ConverterXandY(actualOption);
            if (actualX > 2 || actualY > 2 || actualX < 0 || actualY < 0)
            {
                Console.WriteLine("The value is out of range.");
                Console.WriteLine("Try again.");
                CheckInputSquare();
            }
        }
        //HumanOption
        static void HumanTurn()
        {
            Console.WriteLine("Your turn");
            Console.WriteLine("Choose a square.");
            CheckInputSquare();
            while (!IsTakenSquare())
            {
                Console.WriteLine("That square is taken.");
                Console.WriteLine("Try again.");
                CheckInputSquare();
            }
            tableValues[actualX, actualY] = HUMAN_SIMBOL;
        }
        //ComputerTurn
        static void ComputerTurn()
        {
            actualX = random.Next(0, 3);
            actualY = random.Next(0, 3);
            if (!IsTakenSquare())
            {
                ComputerTurn();
            }
            else
            {
                tableValues[actualX, actualY] = COMPUTER_SIMBOL;
            }
        }
        //Menu
        static void MainMenu()
        {
            Console.WriteLine(TITLE);
            Console.WriteLine("By Emiliano Martel");
            Console.WriteLine("Please select a option");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Instructions");
            Console.WriteLine("3 - Exit");
        }
        //Set default values
        static void SetDefault()
        {
            isHumanTurn = true;
            for (int i = 0; i < tableValues.GetLength(0); i++)
            {
                for (int j = 0; j < tableValues.GetLength(1); j++)
                {
                    tableValues[i, j] = BASIC_VALUE;
                }
            }
        }
        //WriteTable
        static void WriteTable()
        {
            Console.WriteLine($" {tableValues[0,0]} | {tableValues[0, 1]} | {tableValues[0, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tableValues[1, 0]} | {tableValues[1, 1]} | {tableValues[1, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tableValues[2, 0]} | {tableValues[2, 1]} | {tableValues[2, 2]} ");
        }
        //WinLoseLogic
        static bool WinOrLose()
        {
            string preview = "";
            int completeGame = 0;
            int count = 0;
            bool endGame = false;
            for (int i = 0; i < tableValues.GetLength(0); i++)
            {
                count = 0;
                for (int j = 0; j < tableValues.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        preview = tableValues[i, j];
                        count++;
                    }
                    else
                    {
                        if (preview == tableValues[i, j] && tableValues[i, j] != BASIC_VALUE)
                        {
                            count++;
                        }
                    }
                    if (tableValues[i, j] != BASIC_VALUE)
                    {
                        completeGame++;
                    }
                }
                if (count == 3)
                {
                    endGame = true;
                    winner = preview;
                    break;
                }
            }
            for (int j = 0; j < tableValues.GetLength(1); j++)
            {
                count = 0;
                for (int i = 0; i < tableValues.GetLength(1); i++)
                {
                    if (i == 0)
                    {
                        preview = tableValues[i, j];
                        count++;
                    }
                    else
                    {
                        if (preview == tableValues[i, j] && tableValues[i, j] != BASIC_VALUE)
                        {
                            count++;
                        }
                    }
                }
                if (count == 3)
                {
                    endGame = true;
                    winner = preview;
                    break;
                }
            }
            if (tableValues[0, 0] != BASIC_VALUE && tableValues[0, 0] == tableValues[1, 1] && tableValues[1, 1] == tableValues[2, 2])
            {
                endGame = true;
                winner = tableValues[0, 0];
            }
            if (tableValues[0, 2] != BASIC_VALUE && tableValues[0, 2] == tableValues[1, 1] && tableValues[1, 1] == tableValues[2, 0])
            {
                endGame = true;
                winner = tableValues[0, 2];
            }
            if (completeGame == tableValues.Length - 1)
            {
                winner = "";
            }
            return endGame;
        }
        //EndGameMenu
        static void EndGame()
        {
            Console.Clear();
            Console.WriteLine(TITLE);
            WriteTable();
            if (winner == COMPUTER_SIMBOL)
            {
                Console.WriteLine("Computer Wins");
            }
            else if(winner == HUMAN_SIMBOL)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.WriteLine("You want to play again? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.WriteLine("You want to play again? Y/N");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            }
            if (answer == "y")
            {
                SetDefault();
                Console.WriteLine("Good Luck!");
                PressAnyKey();
            }
            else
            {
                rePlay = false;
                Console.WriteLine("Come back to the menu!");
                PressAnyKey();
            }
        }
        //PrimaryLogic
        static void Game()
        {
            SetDefault();
            while (rePlay)
            {
                Console.Clear();
                Console.WriteLine(TITLE);
                WriteTable();
                if (isHumanTurn)
                {
                    HumanTurn();
                    isHumanTurn = false;
                }
                else
                {
                    Console.WriteLine("Is computer turn");
                    ComputerTurn();
                    isHumanTurn = true;
                    Console.WriteLine($"The computer play = {actualX} {actualY}");
                    PressAnyKey();
                }
                if (WinOrLose())
                {
                    EndGame();
                }
            }
        }
        //Instructions
        static void Instructions()
        {
            SetDefault();
            Console.Clear();
            Console.WriteLine(TITLE);
            Console.WriteLine("We have a 3x3 gameboard like this.");
            WriteTable();
            Console.WriteLine("The goal is to form a line of three of your symbols on the board, either horizontally, vertically, or diagonally.");
            Console.WriteLine("The first row goes from 00 to 02.");
            Console.WriteLine("The middel row goes from 10 to 12.");
            Console.WriteLine("The bottom row goes from 20 to 22.");
            Console.WriteLine("You enter where you want to place your symbol, and let's play!");
            PressAnyKey();
        }
    }
}
