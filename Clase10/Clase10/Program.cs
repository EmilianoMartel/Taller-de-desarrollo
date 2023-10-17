using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    class Program
    {
        const string xSimbol = "X";
        const string largeSimbol = "|";
        const string widthSimbol = "-";
        const string noneSimbol = " ";

        static bool isX;
        static int width;
        static int large;

        static int CheckIntInput()
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
                    Console.WriteLine("Ingrese un numero porfavor.");
                }
            } while (!validInput);

            return option;
        }

        static bool CheckPaint()
        {
            string option;
            option = Console.ReadLine();
            option.ToLower();
            bool validInput = false;
            do
            {
                option = Console.ReadLine();
                option.ToLower();
                if (option == "si" || option == "s")
                {
                    return true;
                }
                else if (option == "no" || option == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Input invalido");
                }
            } while (!validInput);
            return false;
        }

        static void DrawTable(int width, int large, bool paint)
        {

        }

        static void MenuDraw()
        {
            Console.WriteLine("Ingresar el alto");
            large = CheckIntInput();
            Console.WriteLine("Ingresar el ancho");
            width = CheckIntInput();
            Console.WriteLine("Lo pinto? s/n");
            isX = CheckPaint();
            DrawTable(width, large, isX);
        }

        static List<int> GetValue(int x1, int x2)
        {
            List<int> yValue = new List<int>();
            for (int i = x1; i <= x2; i++)
            {
                yValue.Add((i - 4) * (i - 4));
            }
            return yValue;
        }

        static void Draw()
        {
            string graphic = "";
            List<int> yValue = GetValue(-1, 8);
            for (int i = 0; i < yValue.Count; i++)
            {
                Console.WriteLine(yValue[i]);
            }
        }


        static void Main(string[] args)
        {
            Draw();
            Console.Read();
        }
    }
}
