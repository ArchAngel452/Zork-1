using System;
using System.Collections.Generic;

namespace Zork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT) 
            {
                Console.WriteLine(Rooms[Location]);
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                switch (command) 
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine("This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork!' lies by the door.");
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command) == false) 
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        else 
                        {
                            Console.WriteLine($"You moved {command}.");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid Direction");
            bool isValidMove = true;

            switch (command) 
            {
                case Commands.EAST when Location < Rooms.GetLength(0) - 1:
                    Location++;
                    break;

                case Commands.WEST when Location > 0:
                    Location--;
                    break;

                default:
                    isValidMove = false;
                    break;
            }

            return isValidMove;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static readonly string[] Rooms = { "Forest", "West Of House", "Behind House", "Clearing", "Canyon View" };

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.WEST,
            Commands.EAST
        };

        private static int Location = 1;
    }
}
