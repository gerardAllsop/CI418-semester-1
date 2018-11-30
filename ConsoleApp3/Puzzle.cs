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
        CastMember cast;

        public Puzzle()
        {
            //actors in the puzzle
            cast = new CastMember();
            //instance of help
            help = new Help();          
        }

        public void printAllPlayerPositions()
        {
            Console.WriteLine(cast.getAllPositions());
        }

        public void printIntro()
        {
            Console.WriteLine(help.getIntroTxt());
        }


        public void printInstructions()
        {
            Console.WriteLine(help.getMenuText());
        }

        public void whereIsPlayer(String player)
        {
            if (cast.isValidCastMember(player))
            {
                Console.WriteLine(cast.getCastMemberPosition(player));
            }
        }
    }
}
