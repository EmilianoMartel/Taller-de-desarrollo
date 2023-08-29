using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quien_es_Quien
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            string playElection = "n";
            string answer;
            string characterDesition;

            //Intro
            Console.WriteLine("Welcome to Quien es Quien by Emiliano Martel");
            Console.WriteLine("If you dont know the game here are instructions,");
            Console.WriteLine("you have to choose a person from the picture");
            Console.WriteLine("and I (the game) am going to try to guess who it is, using yes or no questions.");
            Console.WriteLine("For example, 'Is this person male? Y/N'");
            Console.WriteLine("If it's a male, press the letter Y.");
            Console.WriteLine("If it's a female, press the letter N.");
            Console.WriteLine("Simple, right?");

            //Started game
            Console.WriteLine("Are you ready? Y/N");
            playElection = Console.ReadLine();
            playElection = playElection.ToLower();
            while (playElection != "y")
            {
                switch (playElection)
                {
                    case "n":
                        Console.WriteLine("Okey, take your time.");
                        Console.WriteLine("Are you ready? Y/N");
                        playElection = Console.ReadLine();
                        playElection = playElection.ToLower();
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        Console.WriteLine("Are you ready? Y/N");
                        playElection = Console.ReadLine();
                        playElection = playElection.ToLower();
                        break;
                }
            }

            //Game
            while (playElection == "y")
            {
                Console.WriteLine("Does your character wear a mask? Y/N");
                answer = Console.ReadLine();
                answer = answer.ToLower();

                /*This part of the code will be repeated several times
                 *since we cannot use functions in this exercise. 
                 *It's to ensure that no invalid input is given.*/
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine("Does your character wear a mask? Y/N");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                }

                //Yes, wear a mask.
                if (answer == "y")
                {
                    Console.WriteLine("Does your character have light brown hair? Y/N");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    //Check input
                    while (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("Invalid input, please try again.");
                        Console.WriteLine("Does your character have light brown hair? Y/N");
                        answer = Console.ReadLine();
                        answer = answer.ToLower();
                    }

                    //Yes have a light brown hair ELECTION
                    if (answer == "y")
                    {
                        characterDesition = "Juan";
                    }
                    //No, haven´t a light brown hair ELECTION
                    else
                    {
                        characterDesition = "Hugo";
                    }
                }
                //No, doesn't wear a mask.
                else
                {
                    Console.WriteLine("Does your character wear glasses? Y/N");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    //Check input
                    while (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("Invalid input, please try again.");
                        Console.WriteLine("Does your character wear glasses? Y/N");
                        answer = Console.ReadLine();
                        answer = answer.ToLower();
                    }

                    //Yes, wear glasses
                    if (answer == "y")
                    {
                        Console.WriteLine("Is your character male? Y/N");
                        answer = Console.ReadLine();
                        answer = answer.ToLower();
                        //Check input
                        while (answer != "y" && answer != "n")
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            Console.WriteLine("Is your character male? Y/N");
                            answer = Console.ReadLine();
                            answer = answer.ToLower();
                        }

                        //Yes, is a male ELECTION
                        if (answer == "y")
                        {
                            characterDesition = "Mario";
                        }
                        //No, is a female
                        else
                        {
                            Console.WriteLine("Does your character have a ponytail? Y/N");
                            answer = Console.ReadLine();
                            answer = answer.ToLower();
                            //Check input
                            while (answer != "y" && answer != "n")
                            {
                                Console.WriteLine("Invalid input, please try again.");
                                Console.WriteLine("Does your character have a ponytail? Y/N");
                                answer = Console.ReadLine();
                                answer = answer.ToLower();
                            }

                            //Yes, have a ponytail ELECTION
                            if (answer == "y")
                            {
                                characterDesition = "Carmen";
                            }
                            //No, haven´t a ponytail ELECTION
                            else
                            {
                                characterDesition = "Patricia";
                            }
                        }
                    }
                    //No, doesn't wear glasses.
                    else
                    {
                        Console.WriteLine("Does your character have a hair bow? Y/N");
                        answer = Console.ReadLine();
                        answer = answer.ToLower();
                        //Check input
                        while (answer != "y" && answer != "n")
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            Console.WriteLine("Does your character have a hair bow? Y/N");
                            answer = Console.ReadLine();
                            answer = answer.ToLower();
                        }

                        //Yes, have a hair bow
                        if (answer == "y")
                        {
                            Console.WriteLine("Is your character ginger? Y/N");
                            answer = Console.ReadLine();
                            answer = answer.ToLower();
                            //Check input
                            while (answer != "y" && answer != "n")
                            {
                                Console.WriteLine("Invalid input, please try again.");
                                Console.WriteLine("Is your character ginger? Y/N");
                                answer = Console.ReadLine();
                                answer = answer.ToLower();
                            }

                            //Yes is a ginger ELECTION
                            if (answer == "y")
                            {
                                characterDesition = "Maria";
                            }
                            //No, not is a ginger ELECTION
                            else
                            {
                                characterDesition = "Andrea";
                            }
                        }
                        //No, havent a hair bow
                        else
                        {
                            Console.WriteLine("Does your character have a hat? Y/N");
                            answer = Console.ReadLine();
                            answer = answer.ToLower();
                            //Check input
                            while (answer != "y" && answer != "n")
                            {
                                Console.WriteLine("Invalid input, please try again.");
                                Console.WriteLine("Does your character have a hat? Y/N");
                                answer = Console.ReadLine();
                                answer = answer.ToLower();
                            }

                            //Yes have a hat
                            if (answer == "y")
                            {
                                Console.WriteLine("Is that hat a beret? Y/N");
                                answer = Console.ReadLine();
                                answer = answer.ToLower();
                                //Check input
                                while (answer != "y" && answer != "n")
                                {
                                    Console.WriteLine("Invalid input, please try again.");
                                    Console.WriteLine("Is that hat a beret? Y/N");
                                    answer = Console.ReadLine();
                                    answer = answer.ToLower();
                                }

                                //Yes is a beret ELECTION
                                if (answer == "y")
                                {
                                    characterDesition = "Fernando";
                                }
                                //No is a cap ELECTION
                                else
                                {
                                    characterDesition = "Ruben";
                                }
                            }
                            //No, dont have a hat
                            else
                            {
                                Console.WriteLine("Is your character female? Y/N");
                                answer = Console.ReadLine();
                                answer = answer.ToLower();
                                //Check input
                                while (answer != "y" && answer != "n")
                                {
                                    Console.WriteLine("Invalid input, please try again.");
                                    Console.WriteLine("Is your character female? Y/N");
                                    answer = Console.ReadLine();
                                    answer = answer.ToLower();
                                }

                                //Yes is a female ELECTION
                                if (answer == "y")
                                {
                                    characterDesition = "Ana";
                                }
                                //No, is a male
                                else
                                {
                                    Console.WriteLine("Does your character have black hair? Y/N");
                                    answer = Console.ReadLine();
                                    answer = answer.ToLower();
                                    //Check input
                                    while (answer != "y" && answer != "n")
                                    {
                                        Console.WriteLine("Invalid input, please try again.");
                                        Console.WriteLine("Does your character have black hair? Y/N");
                                        answer = Console.ReadLine();
                                        answer = answer.ToLower();
                                    }

                                    //Yes have a black hair ELECTION
                                    if (answer == "y")
                                    {
                                        characterDesition = "Pedro";
                                    }
                                    //No, dont have a black hair ELECTION
                                    else
                                    {
                                        characterDesition = "Ivan";
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Your character is: {0}", characterDesition);
                Console.WriteLine("Do you want to play again? Y/N");
                playElection = Console.ReadLine();
                playElection = playElection.ToLower();
                //Check input
                while (playElection != "y" && playElection != "n")
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine("Do you want to play again? Y/N");
                    playElection = Console.ReadLine();
                    playElection = answer.ToLower();
                }
            }
            Console.WriteLine("Bye!");
        }
    }
}
