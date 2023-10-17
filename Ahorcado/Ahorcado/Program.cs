using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{

    class Program
    {
        //Const
        const string TITLE =
@"     _     _                                  _        
    / \   | |__    ___   _ __  ___  __ _   __| |  ___  
   / _ \  | '_ \  / _ \ | '__|/ __|/ _` | / _` | / _ \ 
  / ___ \ | | | || (_) || |  | (__| (_| || (_| || (_) |
 /_/   \_\|_| |_| \___/ |_|   \___|\__,_| \__,_| \___/ 
                                                       ";
        const string FIRST_EMPTY_HANGMAN = "+---+  ";
        const string SECOND_EMPTY_HANGMAN = "|   |  ";
        const string THIRD_TO_SIXTH_EMPTY_HANGMAN = "|      ";
        const string SEVENTH_EMPTY_HANGMAN = "=========";
        const string ERROR_ONE = "|   O   ";
        const string ERROR_TWO = "|  /    ";
        const string ERROR_THREE = "|  /|   ";
        const string ERROR_FOUR = @"|  /|\  ";
        const string ERROR_FIVE = "|   |   ";
        const string ERROR_SIX = "|  /    ";
        const string ERROR_SEVEN = @"|  / \  ";

        //Global Variables
        static int choose = 0;
        static bool rePlay = true;
        static string[] basciHangman = new string[7]
    {
        FIRST_EMPTY_HANGMAN,
        SECOND_EMPTY_HANGMAN,
        THIRD_TO_SIXTH_EMPTY_HANGMAN,
        THIRD_TO_SIXTH_EMPTY_HANGMAN,
        THIRD_TO_SIXTH_EMPTY_HANGMAN,
        THIRD_TO_SIXTH_EMPTY_HANGMAN,
        SEVENTH_EMPTY_HANGMAN
    };
        static string[] actualHangman = new string[7]
    {
        "+---+  ",
        "|   |  ",
        "|      ",
        "|      ",
        "|      ",
        "|      ",
        "========="
    };
        static int numErrors = 0;
        static int numCorrectHits = 0;
        static List<string> wordList = new List<string> { "AHORA", "AHORCADO", "LISTA", "FLAUTA", "RELLENO", "CURADO", "VERSION", "YERBA", "BOTELLA","ENFERMERO" };
        static string[] wordToGuess;
        static string[] letters;
        static string randomWord;
        static string goodLetters = "";
        static string errorLetters = "";
        static string choosenLetter = "";


        static void Main(string[] args)
        {
            Menu();
        }
        //Functions
        static void Menu()
        {
            while (choose != 4)
            {
                rePlay = true;
                Console.Clear();
                Console.WriteLine(TITLE);
                Console.WriteLine("Por Emiliano Martel");
                Console.WriteLine("Porfavor seleccione una opcion");
                Console.WriteLine("1 - Jugar");
                Console.WriteLine("2 - Instrucciones");
                Console.WriteLine("3 - Añadir palabras");
                Console.WriteLine("4 - Salir");
                choose = MaxInputCheck(4);
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        Game();
                        break;
                    case 2:
                        Instructions();
                        break;
                    case 3:
                        AddWord();
                        break;
                }
            }
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

        static void Instructions()
        {
            Console.Clear();
            Console.WriteLine(TITLE);
            Console.WriteLine("La meta del juego es adivinar la palabra.");
            Console.WriteLine("Para ello deberas ir diciendo letras de la A a la Z, ");
            Console.WriteLine("y si esta se encuentra en la palabra aparecera en pantalla donde se encuentra.");
            Console.WriteLine("Pero si la letra no se encuentra en la palabra perdes un intento, y solo contas con 7.");
            Console.WriteLine("Por ejemplo:");
            DisplayHangman();
            Console.WriteLine("_ _ _ _ _ _ _ ");
            Console.WriteLine("Ingresamos la letra A");
            Console.WriteLine("_ A _ _ _ _ A ");
            Console.WriteLine("Pero si ingresamos la letra I, la cual no se encuentra tenemos el primer error y se mostrara de la siguiente forma.");
            ErrorHangman(1);
            DisplayHangman();
            Console.WriteLine("Cuando estes listx presiona cualquier tecla para volver al menu.");
            BasicHangman();
            PressAnyKey();
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue.");
            while (Console.KeyAvailable)
            {
                Console.ReadKey(intercept: true);
            }
            Console.ReadKey(intercept: true);
        }

        //DisplayHangman Functions
        static void DisplayHangman()
        {
            foreach (string line in actualHangman)
            {
                Console.WriteLine(line);
            }
        }

        static void ErrorHangman(int numError)
        {
            switch (numError)
            {
                case 1:
                    actualHangman[2] = ERROR_ONE;
                    break;
                case 2:
                    actualHangman[3] = ERROR_TWO;
                    break;
                case 3:
                    actualHangman[3] = ERROR_THREE;
                    break;
                case 4:
                    actualHangman[3] = ERROR_FOUR;
                    break;
                case 5:
                    actualHangman[4] = ERROR_FIVE;
                    break;
                case 6:
                    actualHangman[5] = ERROR_SIX;
                    break;
                case 7:
                    actualHangman[5] = ERROR_SEVEN;
                    break;
                default:
                    throw new Exception("Error: Invalid num error.");
                    break;
            }
        }

        static void BasicHangman()
        {
            for (int i = 0; i < actualHangman.Length; i++)
            {
                actualHangman[i] = basciHangman[i];
            }
        }

        static void DisplayWord()
        {
            foreach (string line in wordToGuess)
            {
                Console.Write(line + " ");
            }
            Console.WriteLine();
        }

        static void SetGame()
        {
            numCorrectHits = 0;
            numErrors = 0;
            goodLetters = "";
            errorLetters = "";
            choosenLetter = "";
            randomWord = GetRandomWord();
            wordToGuess = new string[randomWord.Length];
            letters = new string[randomWord.Length];
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                wordToGuess[i] = "_";
            }
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = randomWord[i].ToString();
            }
            BasicHangman();
        }

        static string ValidStringInput(int inputLength = 1)
        {
            bool validInput = true;
            string input = Console.ReadLine();
            if (inputLength == 1 && input.Length == 1)
            {
                validInput = true;
            }
            else if (inputLength == 1 && input.Length != 1)
            {
                validInput = false;
            }
            else if (inputLength > 1)
            {
                validInput = true;
            }
            if (validInput && !string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input) && !int.TryParse(input, out int numero))
            {
                return input.ToUpper();
            }
            else
            {
                Console.WriteLine("Input invalido, intentelo nuevamente.");
                return ValidStringInput();
            }
        }

        static void CheckInputLogic()
        {
            choosenLetter = ValidStringInput();
            choosenLetter = choosenLetter.ToUpper();
            while (errorLetters.Contains(choosenLetter) || goodLetters.Contains(choosenLetter))
            {
                Console.WriteLine("Ya elegiste esa letra, intentalo nuevamente.");
                choosenLetter = ValidStringInput();
                choosenLetter = choosenLetter.ToUpper();
            }
        }

        static void Game()
        {
            SetGame();
            while (rePlay)
            {
                Console.Clear();
                DisplayHangman();
                DisplayWord();
                Console.WriteLine($"Intentos fallidos ({numErrors}): {errorLetters}");
                Console.WriteLine("Ingrese una letra");
                CheckInputLogic();
                CheckLetters();
                WinLoseLogic();
            }
        }

        static string GetRandomWord()
        {
            Random random = new Random();
            int index = random.Next(wordList.Count);
            return wordList[index];
        }

        static void CheckLetters()
        {
            if (randomWord.Contains(choosenLetter))
            {
                goodLetters += choosenLetter + " ";
                for (int i = 0; i < letters.Length; i++)
                {
                    if (choosenLetter == letters[i])
                    {
                        numCorrectHits++;
                        wordToGuess[i] = choosenLetter;
                    }
                }
            }
            else
            {
                errorLetters += choosenLetter + " ";
                numErrors++;
                ErrorHangman(numErrors);
            }
        }

        static void WinLoseLogic()
        {
            if (numCorrectHits == randomWord.Length)
            {
                EndGame(true);
            }
            else if (numErrors == 7)
            {
                EndGame(false);
            }
        }

        static void EndGame(bool playerWin)
        {
            string yesOrNo;
            Console.Clear();
            DisplayHangman();
            DisplayWord();
            Console.WriteLine($"Intentos fallidos ({numErrors}): {errorLetters}");
            if (playerWin)
            {
                Console.WriteLine("Felicidades! Ganaste!");
            }
            else
            {
                Console.WriteLine("Que pena perdiste!");
            }
            Console.WriteLine("¿Queres jugar nuevamente?  Y/N");
            yesOrNo = ValidStringInput();
            while (yesOrNo != "Y" && yesOrNo != "N")
            {
                Console.WriteLine(yesOrNo);
                Console.WriteLine("Input invalido ¿Queres jugar nuevamente?  Y/N");
                yesOrNo = ValidStringInput();
            };
            if (yesOrNo == "Y")
            {
                SetGame();
            }
            else
            {
                rePlay = false;
            }
        }

        static void AddWord()
        {
            string newWord;
            Console.Clear();
            Console.WriteLine(TITLE);
            Console.WriteLine("Porfavor ingrese una palabra nueva: ");
            newWord = ValidStringInput(int.MaxValue);
            wordList.Add(newWord);
        }
    }

}

