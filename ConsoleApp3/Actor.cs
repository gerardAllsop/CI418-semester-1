using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Actor
    {
        //can hold one of two values - true or false
        private bool bank;
        public string Name { get; private set; }

        public Actor(string name)
        {
            //false is synonymous with LEFT BANK
            //true is synonymous  with RIGHT BANK
            Name = name;
            bank = false;
        }

        public String getPosition()
        {
            if (bank == false) 
                return "The "+ Name +" is on the left bank\n";
            else
                return "The " + Name + " is on the left bank\n";
        }
    }
}

