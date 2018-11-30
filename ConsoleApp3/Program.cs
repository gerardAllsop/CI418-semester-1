using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn

{
    class Program
    {
        static void Main(string[] args)
        {
            //we'll create a Puzzle class object
            Puzzle puzzle = new Puzzle();
            string userResponse = "";

            //print out the intro txt
            puzzle.printIntro();
            puzzle.printAllPlayerPositions();

            while (!userResponse.Equals("4"))
            {
                puzzle.printInstructions();
                userResponse = Console.ReadLine();
                Console.Clear();
                //rewrite as switch statement
                if (userResponse.Equals("1"))
                    puzzle.printIntro();
                else if (userResponse.Equals("2"))
                    puzzle.printAllPlayerPositions();
                else if (userResponse.Equals("3"))
                {
                    Console.Write("Player: ");
                    string player = Console.ReadLine();
                    puzzle.whereIsPlayer(player);
                }
    
            }
        }
    }
}
