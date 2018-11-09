using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class CastMembers
    {
        private static List<string> roles = new List<String> { "farmer", "fox", "goose", "corn" };
        public static List<string> Roles { get => roles; }
        
        public static bool isValidRole(string name)
        {
            foreach(var role in roles)
            {
                if (role.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
