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
        private string name;

        public Actor(string name)
        {
            //false is synonymous with LEFT BANK
            //true is synonymous  with RIGHT BANK
            this.name = name;
            bank = false;
        }

        public String getPosition()
        {
            if (bank == false) 
                return "The "+ name +" is on the left bank";
            else
                return "The " + name + " is on the left bank";
        }
    }
}

