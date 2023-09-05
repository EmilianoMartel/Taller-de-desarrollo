using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelOTijera
{
    class Program
    {
        enum Election
        {
            Rock,
            Scissors,
            Paper
        }

        //ASCCI ART
        const string ROCKART =
@"       _  _
   __/o \/o\__
  /   \__/   \
 |    ROCK    |
  \  \__/\__/  /
    \_      _/
      \___/";
        const string SCISSORSART =
@"   \   /   
    \ /    
    / \
   /   \
";
        const string PAPERART =
@" ________
|        |
|        |
|        | 
|        |  
|        |   
|        |    
|        |     
|________|
";
        const string TITEL =
@" ____  ____  ____  _  __    ____  ____  ____  _____ ____     ____  ____  _  ____  ____  ____  ____  ____ 
/  __\/  _ \/   _\/ |/ /   /  __\/  _ \/  __\/  __//  __\   / ___\/   _\/ \/ ___\/ ___\/  _ \/  __\/ ___\
|  \/|| / \||  /  |   /    |  \/|| / \||  \/||  \  |  \/|   |    \|  /  | ||    \|    \| / \||  \/||    \
|    /| \_/||  \_ |   \    |  __/| |-|||  __/|  /_ |    /   \___ ||  \_ | |\___ |\___ || \_/||    /\___ |
\_/\_\\____/\____/\_|\_\_  \_/   \_/ \|\_/   \____\\_/\_\_  \____/\____/\_/\____/\____/\____/\_/\_\\____/
                       |/                               |/                                               ";
        const string DRAW =
@"|_   _ `.|_   __ \        / \|_  _|    |_  _|
  | | `. \ | |__) |      / _ \ \ \  /\  / /  
  | |  | | |  __ /      / ___ \ \ \/  \/ /   
 _| |_.' /_| |  \ \_  _/ /   \ \_\  /\  /    
|______.'|____| |___||____| |____|\/  \/     ";
        const string WIN =
@"|_  _|    |_  _||_   _||_   \|_   _| 
  \ \  /\  / /    | |    |   \ | |   
   \ \/  \/ /     | |    | |\ \| |   
    \  /\  /     _| |_  _| |_\   |_  
     \/  \/     |_____||_____|\____| 
                                     ";
        const string LOSE =
@" _____       ___     ______   ________  
 |_   _|    .'   `. .' ____ \ |_   __  | 
   | |     /  .-.  \| (___ \_|  | |_ \_| 
   | |   _ | |   | | _.____`.   |  _| _  
  _| |__/ |\  `-'  /| \____) | _| |__/ | 
 |________| `.___.'  \______.'|________| 
                                         ";
        const string VS =
@"__   __ ___ 
\ \ / // __|
 \ V / \__ \
  \_/  |___/";
        const string YOU =
@" __     __ ____   _    _ 
 \ \   / // __ \ | |  | |
  \ \_/ /| |  | || |  | |
   \   / | |  | || |  | |
    | |  | |__| || |__| |
    |_|   \____/  \____/ 
                         
                         ";
        static void Main(string[] args)
        {
            Random random = new Random();

            string exit = "n";
            string rePlay = "y";
            string answer = "";

            //Player election
            string playerElection = "";
            Election enumPlayerElection;
            string playerArt;

            //Computer election
            int computerElection;
            Election enumComputerElection;
            string computerArt;

            //Count Wins
            int playerWins = 0;
            int computerWins = 0;

            while (exit != "y")
            {
                Console.WriteLine(TITEL);
                Console.WriteLine("by Emiliano Martel");
                Console.WriteLine("Choose an option (1, 2 or 3):");
                Console.WriteLine("1-Play");
                Console.WriteLine("2-Instructions");
                Console.WriteLine("3-Exit");
                answer = Console.ReadLine();
                //Check Input
                while (answer != "1" && answer != "2" && answer != "3")
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine("Choose an option (1, 2 or 3):");
                    Console.WriteLine("1-Play");
                    Console.WriteLine("2-Instructions");
                    Console.WriteLine("3-Exit");
                    answer = Console.ReadLine();
                }

                switch (answer)
                {
                    case "1":
                        //GAME
                        while (rePlay == "y")
                        {
                            Console.Clear();
                            for (int i = 1; i < 6; i++)
                            {
                                Console.WriteLine(TITEL);
                                Console.WriteLine($"Round {i}");
                                Console.WriteLine($"Player Wins: {playerWins}---Computer Wins: {computerWins}");
                                Console.WriteLine("Choose an option (1, 2 or 3):");
                                Console.WriteLine("1-Rock");
                                Console.WriteLine("2-Paper");
                                Console.WriteLine("3-Scissors");
                                playerElection = Console.ReadLine();

                                //InputCheck
                                while (playerElection != "1" && playerElection != "2" && playerElection != "3")
                                {
                                    Console.WriteLine("Invalid input, please try again.");
                                    Console.WriteLine("Choose an option (1, 2 or 3):");
                                    Console.WriteLine("1-Rock");
                                    Console.WriteLine("2-Paper");
                                    Console.WriteLine("3-Scissors");
                                    playerElection = Console.ReadLine();
                                }

                                //PlayerElection
                                if (playerElection == "1") enumPlayerElection = Election.Rock;
                                else if (playerElection == "2") enumPlayerElection = Election.Paper;
                                else enumPlayerElection = Election.Scissors;

                                //ComputerElection
                                computerElection = random.Next(1, 4);
                                if (computerElection == 1) enumComputerElection = Election.Rock;
                                else if (computerElection == 2) enumComputerElection = Election.Paper;
                                else enumComputerElection = Election.Scissors;

                                //This switch is more easy to read the elections
                                switch (enumPlayerElection)
                                {
                                    case Election.Rock:
                                        playerArt = ROCKART;
                                        switch (enumComputerElection)
                                        {
                                            case Election.Rock:
                                                computerArt = ROCKART;
                                                Console.WriteLine(DRAW);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                break;
                                            case Election.Paper:
                                                computerArt = PAPERART;
                                                Console.WriteLine(LOSE);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                computerWins++;
                                                break;
                                            case Election.Scissors:
                                                computerArt = SCISSORSART;
                                                Console.WriteLine(WIN);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                playerWins++;
                                                break;
                                        }
                                        break;
                                    case Election.Paper:
                                        playerArt = PAPERART;
                                        switch (enumComputerElection)
                                        {
                                            case Election.Rock:
                                                computerArt = ROCKART;
                                                Console.WriteLine(WIN);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                playerWins++;
                                                break;
                                            case Election.Paper:
                                                computerArt = PAPERART;
                                                Console.WriteLine(DRAW);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                break;
                                            case Election.Scissors:
                                                computerArt = SCISSORSART;
                                                Console.WriteLine(LOSE);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                computerWins++;
                                                break;
                                        }
                                        break;
                                    case Election.Scissors:
                                        playerArt = SCISSORSART;
                                        switch (enumComputerElection)
                                        {
                                            case Election.Rock:
                                                computerArt = ROCKART;
                                                Console.WriteLine(LOSE);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                computerWins++;
                                                break;
                                            case Election.Paper:
                                                computerArt = PAPERART;
                                                Console.WriteLine(WIN);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                playerWins++;
                                                break;
                                            case Election.Scissors:
                                                computerArt = SCISSORSART;
                                                Console.WriteLine(DRAW);
                                                Console.WriteLine($"{playerArt}\n{VS}\n{computerArt}");
                                                break;
                                        }
                                        break;
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }

                            Console.WriteLine(YOU);
                            if (playerWins > computerWins) Console.WriteLine(WIN);
                            else if (playerWins < computerWins) Console.WriteLine(LOSE);
                            else Console.WriteLine(DRAW);

                            playerWins = 0;
                            computerWins = 0;

                            Console.WriteLine("Play again? y/n");
                            rePlay = Console.ReadLine();
                            rePlay.ToLower();

                            //InputCheck
                            while (exit != "n" && exit != "y")
                            {
                                Console.WriteLine("Invalid input, please try again.");
                                Console.WriteLine("Play again? y/n");
                                rePlay = Console.ReadLine();
                                rePlay.ToLower();
                            }

                            if (rePlay == "n")
                            {
                                Console.WriteLine("Would you like to exit? y/n");
                                exit = Console.ReadLine();
                                exit.ToLower();

                                //Input Check
                                while (exit != "n" && exit != "y")
                                {
                                    Console.WriteLine("Invalid input, please try again.");
                                    Console.WriteLine("Would you like to exit? y/n");
                                    exit = Console.ReadLine();
                                    exit.ToLower();
                                }
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("We have a 5 rounds. In every round we must choose between rock paper or scissors.");
                        Console.WriteLine(" Each of these elements has a winning and losing relationship with the other two:");
                        Console.WriteLine("Rock beats Scissors (rock crushes scissors).");
                        Console.WriteLine("Scissors beat Paper(scissors cut paper).");
                        Console.WriteLine("Paper beats Rock(paper covers rock).");
                        Console.WriteLine("Press any button to back to menu");
                        Console.ReadKey();
                        Console.Clear();
                        answer = "";
                        break;
                    case "3":
                        Console.WriteLine("Are you sure? y/n");
                        exit = Console.ReadLine();
                        exit.ToLower();

                        //Input Check
                        while (exit != "n" && exit != "y")
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            Console.WriteLine("Are you sure? y/n");
                            exit = Console.ReadLine();
                            exit.ToLower();
                        }
                        break;
                }
            }
        }
    }
}
