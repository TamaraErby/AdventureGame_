using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle("StarQuest");
            first();
            startOver();
            startNewGame();
            mayTheForce();
        }

        public static void gameTitle(string v)
        {
            Console.WriteLine("Welcome to Star Quest. You are a rebel spy on the Death Star and your mission is to disable the shields while remaining undetected.\n" +
                "Traverse through different corridors and different scenarios to complete your mission.");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You arrive at a private hanger bay via the Imperial Shuttle.");
            Console.WriteLine("In the hanger bay there's 3 hallways that branches out from your position.");
            Console.WriteLine("Type 'Left' to go towards Hallway 1.");
            Console.WriteLine("Type 'Forward' to go towards Hallway 2.");
            Console.WriteLine("Type 'Right' to go towards Hallway 3.");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "Left":
                case "left":
                case "LEFT":
                    {
                        Console.WriteLine("You are now in a Private Lounge Area.");
                        Console.WriteLine("To your left, you notice an object that looks similar to Darth Vader's Lightsaber.");
                        Console.WriteLine("What do you do?");
                        Console.WriteLine("1. Pick it up.");
                        Console.WriteLine("2. Ignore it.");

                        string scenario1;
                        scenario1 = Console.ReadLine();

                        switch (scenario1)
                        {
                            case "1":
                                {

                                    Console.WriteLine("Unfortunately, this was a trap.");
                                    Console.WriteLine();
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("To start a New Game, press 'Enter'.");
                                    Console.ReadLine();
                                    startNewGame();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Congratulations, you survived.");
                                    Console.WriteLine("You can now turn around and go back to the private hanger bay to choose a different hallway.");
                                    Console.WriteLine();
                                    Console.WriteLine("Press 'Enter' to continue your journey to disabling the shields.");
                                    Console.ReadLine();
                                    startOver();
                                    break;
                                }
                        }
                    }
                    break;

                case "Forward":
                case "forward":
                case "FORWARD":
                    {
                        Console.WriteLine("As you begin walking down the corridor, you notice a Storm Trooper patrol running in your direction.");
                        Console.WriteLine("What do you do?");
                        Console.WriteLine("1. Fight");
                        Console.WriteLine("2. Hide");
                        Console.WriteLine("3. Run away");

                        string scenario2;
                        scenario2 = Console.ReadLine();

                        switch (scenario2)
                        {
                            case "1":
                                {
                                    Console.WriteLine("You were blasted into dust while full-sending.");
                                    Console.WriteLine();
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("To start a New Game, press 'Enter'.");
                                    Console.ReadLine();
                                    startNewGame();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("You successfully hid from the patrol in a nearby empty storage box.");
                                    Console.WriteLine("You can now turn around and go back to the private hanger bay to choose a different hallway.");
                                    Console.WriteLine();
                                    Console.WriteLine("Press 'Enter' to continue your journey to disabling the shields.");
                                    Console.ReadLine();
                                    startOver();
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("While running away, you ran into another patrol and was blasted into dust.");
                                    Console.WriteLine();
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("To start a New Game, press 'Enter'.");
                                    Console.ReadLine();
                                    startNewGame();
                                    break;
                                }
                        }
                    }
                    break;

                case "Right":
                case "right":
                case "RIGHT":
                    {
                        Console.WriteLine("As you're walking down the corridor, you notice an ajar door to your right.");
                        Console.WriteLine("Behind the door, there's a set of power couplings.");
                        Console.WriteLine("You have the option to: \n" +
                            "1. Use a LK-4 fusible link.\n" +
                            "2. Use a power tap.");

                        string scenario3;
                        scenario3 = Console.ReadLine();

                        switch (scenario3)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Congratulations! The shield generator will shut down upon reaching 50% power.");
                                    Console.WriteLine();
                                    Console.WriteLine("YOU WIN!!!");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Press 'Enter'.");
                                    Console.ReadLine();
                                    mayTheForce();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Congratulations! The shield generator will shut down upon activation of the power tap.");
                                    Console.WriteLine();
                                    Console.WriteLine("YOU WIN!!!");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Press 'Enter'.");
                                    Console.ReadLine();
                                    mayTheForce();
                                    break;
                                }
                        }

                    }
                    break;

                default:
                    {
                        Console.WriteLine("Invalid Entry.");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        first();
                        break;

                    }
            }
        }

        public static void startOver()
        {
            Console.Clear();
            Console.WriteLine("Press 'Enter' to choose a different hallway.");
            Console.ReadLine();
            first();
        }

        public static void startNewGame()
        {
            Console.Clear();
            Console.WriteLine("Press 'Enter' to go to the Main Menu.");
            Console.ReadLine();
            first();
        }

        public static void mayTheForce()
        {
            Console.Clear();
            Console.WriteLine("MAY THE FORCE BE WITH YOU!");
            Console.ReadLine();
            first();
        }
    }
}









