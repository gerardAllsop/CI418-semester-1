using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class MenuItems
    {
        private Dictionary<int, string> menuList;
        public string MenuString {
            get {
                StringBuilder menuString = new StringBuilder();
                 foreach(var key in menuList.Keys)
                {
                    string str = string.Format("{0}: {1} ",key,menuList[key]);
                   menuString.Append(str);
                }
                return menuString.ToString();
            }
            private set{;}
            }

        public MenuItems()
        {
            menuList = new Dictionary<int,string>();
            menuList.Add(1,"Repeat Intro");
            menuList.Add(2, "Where is Everybody?");
            menuList.Add(3, "Where is...");
            menuList.Add(4, "Quit");
        }

        public string getMenuItem(int index)
        {
            if (menuList.ContainsKey(index))
            {
                return menuList[index];
            }
            else
            {
                return "No such menu item";
            }
        }
    }
}
