using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFunciones
{
    class Program
    {
        const string PLAYER =
@"\(-.-)/";
        static void Main(string[] args)
        {
            /*int num1;
            int num2;
            int result;
            //Ejercicio1
            Console.WriteLine("Ingrese un numero");
            num1 = VerifyIntegerInput();
            CheckPositive(num1);
            //Ejercicio2
            Console.WriteLine("Ingrese un numero");
            num1 = VerifyIntegerInput();
            Console.WriteLine("Ingrese el segundo numero");
            num2 = VerifyIntegerInput();
            Console.WriteLine($"El resultado es: {Multipy(num1,num2)}");
            //Ejercicio3
            Console.WriteLine("Ingrese un numero");
            num1 = VerifyIntegerInput();
            CompareToTwenty(num1);
            //Ejercicio4
            Console.WriteLine("Ingrese un numero");
            num1 = VerifyIntegerInput();
            if (CheckDivisibleByFive(num1))
            {
                Console.WriteLine("Es divisible por 5");
            }
            else
            {
                Console.WriteLine("No es divisible por 5");
            }
            //Ejercicio5
            Console.WriteLine("Ingrese un numero");
            num1 = VerifyIntegerInput();
            while (num1 != 0)
            {

            }
            Console.ReadLine();*/
            string movementPlayer = "";
            string previewMovementPlayer = movementPlayer;
            Console.WriteLine(PLAYER);
            while (true)
            {
                movementPlayer = Movement(movementPlayer);
                if (movementPlayer != previewMovementPlayer)
                {
                    Console.Clear();
                    previewMovementPlayer = movementPlayer;
                }
                Console.WriteLine(movementPlayer + PLAYER);
            }
        }

        static string Movement(string movementPlayer)
        {
            int maxDimention = 30;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (movementPlayer != "")
                    {
                        movementPlayer = movementPlayer.Remove(0,1);
                    }
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    if (movementPlayer.Length < maxDimention)
                    {
                        movementPlayer += " ";
                    }
                    break;
                case ConsoleKey.DownArrow:
                    break;
                default:
                    break;
            }
            return movementPlayer;
        }

        static int VerifyIntegerInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Ingrese un numero valido: ");
            }
            return num;
        }

        static void CheckPositive(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
        }

        static int Multipy(int num1, int num2)
        {
            return num1 * num2;
        }

        static void CompareToTwenty(int num)
        {
            if (num < 20)
            {
                Console.WriteLine("Es menor que 20");
            }
            else if (num > 20)
            {
                Console.WriteLine("Es mayor que 20");
            }
            else
            {
                Console.WriteLine("Es igual a 20");
            }
        }

        static bool CheckDivisibleByFive(int num)
        {
            return num % 5 == 0;
        }

        static void CheckOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Es un numero par");
            }
            else
            {
                Console.WriteLine("Es un numero impar");
            }
        }
    }
}
