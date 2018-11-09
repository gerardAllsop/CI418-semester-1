using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Puzzle
    {    
        Actor farmer, fox, corn, goose;
        Help help;

        public Puzzle()
        {
            //4 actors in the puzzle
            farmer = new Actor("Farmer");
            fox = new Actor("Fox");
            goose = new Actor("Goose");
            corn = new Actor("Corn");
            //instance of help
            help = new Help();
        }

        public void printIntro()
        {
            Console.WriteLine(help.getIntroTxt());
        }

        public void printAllPlayerPositions()
        {
            Console.WriteLine(farmer.getPosition());
            Console.WriteLine(fox.getPosition());
            Console.WriteLine(goose.getPosition());
            Console.WriteLine(corn.getPosition());
        }

        public void printInstructions()
        {
            Console.WriteLine(help.getHelpKeys());
        }

        public void printPlayerPosition(String player)
        {
            if(player.Equals("farmer"))
                Console.WriteLine(farmer.getPosition());
            if (player.Equals("fox"))
                Console.WriteLine(fox.getPosition());
            if (player.Equals("goose"))
                Console.WriteLine(goose.getPosition());
            if (player.Equals("corn"))
                Console.WriteLine(corn.getPosition());
        }
    }
}
