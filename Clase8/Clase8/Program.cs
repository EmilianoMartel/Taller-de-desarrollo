using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    class Program
    {

        static string[] names = new string[5];
        static int[] ages = new int[5];
        static int[] nums = new int[4];
        static void Main(string[] args)
        {
            
            int[] sums = {0,4,3,10,2 };
            Ejercicio3();
            Console.Read();
        }

        static void Ejercicio1()
        {
            string input;
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Ingrese el {1} nombre: ");
                names[i] = Console.ReadLine();
                Console.WriteLine($"Ingrese el {2} nombre: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    ages[i] = result;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (ages[i] >= 18)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }

        static void Ejercicio2()
        {
            string input;
            int sum = 0;
            float average;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Ingrese el {2} nombre: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    nums[i] = result;
                }
            }

            foreach (int num in nums)
            {
                sum += num;
            }

            average = sum / nums.Length;

            Console.WriteLine(average);
        }

        static int SumarNumeros(int[] sums)
        {
            int sum = 0;
            foreach (int num in sums)
            {
                sum += num;
            }
            return sum;
        }

        static void Ejercicio3()
        {
            string[,] namesAndCountries = new string[5,2];

            for (int i = 0; i < namesAndCountries.GetLength(0); i++)
            {
                Console.Write($"Ingrese el nombre {i + 1}: ");
                namesAndCountries[i, 0] = Console.ReadLine();
                Console.Write($"Ingrese el país {i + 1}: ");
                namesAndCountries[i, 1] = Console.ReadLine();
            }

            for (int j = 0; j < namesAndCountries.GetLength(0); j++)
            {
                if (namesAndCountries[j, 1] == "Argentina")
                {
                    Console.WriteLine(namesAndCountries[j, 0]);
                }
            }
        }
    }
}
