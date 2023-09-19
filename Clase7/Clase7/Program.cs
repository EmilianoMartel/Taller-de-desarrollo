using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FuncionTres("aloha"));
            Console.ReadLine();
        }

        static int FuncionUno(int n)
        {
            if (n == 1)
                return n;
            return n + FuncionUno(n - 1);
        }

        //Funcion para ver si un numero es binario
        static bool FuncionDos(int n)
        {
            if (n == 0 || n == 1)
            {
                return true;
            }
            if (n < 0 || n % 10 != 0 && n % 10 != 1)
            {
                return false;
            }
            return FuncionDos(n / 10);
        }

        //Funcion para ver si un numero es binario con string
        static bool FuncionDosString(int num)
        {
            string text = num.ToString();
            if (text.Length == 1)
            {
                return text == "0" || text == "1";
            }

            string firstDigit = text.Substring(0, 1);
            string otherPart = text.Substring(1);
            return FuncionDosString(int.Parse(firstDigit)) && FuncionDosString(int.Parse(otherPart));
        }

        //Con una funcion recursiva si una palabra es un palindromo
        static bool FuncionTres(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }
            else if (word[0] != word[word.Length - 1])
            {
                return false;
            }
            string removedWord = word.Substring(1, word.Length - 2);
            return FuncionTres(removedWord);
        }
    }
}
