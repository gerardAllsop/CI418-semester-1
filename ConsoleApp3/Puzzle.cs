using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Puzzle
    {    
        private List<Actor> actors;
        Help help;

        public Puzzle()
        {
            //actors in THIS puzzle
            actors = new List<Actor>();
            //for each valid role in the puzzle
            CastMembers.Roles.ForEach(role => actors.Add(new Actor(role)));
            //instance of help
            help = new Help();
        }


        public void printAllPlayerPositions()
        {
            actors.ForEach(actor => Console.WriteLine(actor.getPosition()));
        }

        public void printPlayerPosition(String player)
        {
            if (!CastMembers.isValidRole(player))
            {
                Console.WriteLine("{0} is not a valid role", player);
            }
            else{
                foreach(var actor in actors)
                {
                    if(actor.Name.Equals(player))
                    {
                        Console.WriteLine(actor.getPosition());
                    }
                }
            }
        }

        public void printIntro()
        {
            Console.WriteLine(help.getIntroTxt());
        }

        public void printInstructions()
        {
            Console.WriteLine(help.getHelpKeys());
        }
    }
}
