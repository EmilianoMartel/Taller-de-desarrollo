using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    class Program
    {
        static Dictionary<string, List<string>> iceCreamDictionary = new Dictionary<string, List<string>>();
        static Dictionary<string, string> morseCodeDictionary = new Dictionary<string, string> {
            {"A", ".-" },{"B", "-..."},{"C", "-.-."},{"D", "-.." },{"E", "." },{"F", "..-." },{"G", "--." },{"H", "...." },{"I", ".." },
            {"J", ".---" },{"K", "-.-" },{"L", ".-.." },{"M", "--" },{"N", "-." },{"O", "---" },{"P", ".--." },{"Q", "--.-" },{"R", ".-." },
            {"S", "..." },{"T", "-" },{"U", "..-" },{"V", "...-" },{"W", ".--" },{"X", "-..-" },{"Y", "-.--" },{"Z", "--.." },{"1", ".----" },
            {"2", "..---" },{"3", "...--" },{"4", "....-" },{"5", "....." },{"6", "-...." },{"7", "--..." },{"8", "---.." },{"9", "----." },
            {"0", "-----" }
        };

        static void Main(string[] args)
        {
            string word;
            string morseCode;
            Console.WriteLine("Wrtite a word");
            word = Console.ReadLine();
            morseCode = GetMorseCode(word);
            Console.WriteLine(morseCode);
            string wordReturn = ReturWord(morseCode);
            Console.WriteLine(wordReturn);
            Console.ReadLine();
        }

        //Desarroll uan funcion que reciba una lista de palabras y un prefijo, y retorne en una lista todas las palabras 
        //que inicien con un prefijo dado
        static List<string> Ejercicio1(List<string> wordList, string prefix)
        {
            List<string> newList = new List<string>();

            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i].StartsWith(prefix))
                {
                    newList.Add(wordList[i]);
                }
            }

            return newList;
        }

        //teniendo un diccionario que contiene como llave el nombre de una persona y como valor una lista
        //con todos sus gustos de helado,  desarrollar una funcion agregar gusto
        static void AddTaste(string name, string iceCreamTaste)
        {
            if (iceCreamDictionary.ContainsKey(name))
            {
                if (!iceCreamDictionary[name].Contains(iceCreamTaste))
                {
                    iceCreamDictionary[name].Add(iceCreamTaste);
                }
            }
            else
            {
                iceCreamDictionary[name] = new List<string>();
                iceCreamDictionary[name].Add(iceCreamTaste);
            }
        }

        /*Desarrollar una función que reciba una string y retorne el códigomorse respectivo. 
         * El código morse de cada letra debe estar separado por un espacio en blanco. 
         * Porejemplo para “hola”retorna “.... --- .-.. .-“*/
        static string GetMorseCode(string word)
        {
            string morseCode = "";
            foreach (char letter in word.ToUpper())
            {
                if (morseCodeDictionary.ContainsKey(letter.ToString()))
                {
                    morseCode += morseCodeDictionary[letter.ToString()] + " ";
                }
            }
            return morseCode;
        }

        /*Desarrollar una función que reciba un string correspondiente a una palabra en código morse
         * (separadas las claves morse de cada letra por un espacio en blanco),
         * y que retorne la palabrarespectiva. Por ejemplo para “-. .- -. .-” retorna “nana”.*/
        static string ReturWord(string morse)
        {
            Dictionary<string, string> invertedDictionary = morseCodeDictionary.ToDictionary(pair => pair.Value, pair => pair.Key);
            string word = "";
            string[] separateCode = morse.Split(' ');

            foreach (string code in separateCode)
            {
                if (invertedDictionary.ContainsKey(code))
                {
                    word += invertedDictionary[code].ToString();
                }
            }

            return word;
        }
    }
}
