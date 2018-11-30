using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class CastMember
    {
        private List<Actor> cast;

        public CastMember()
        {
            cast = new List<Actor>();
            cast.Add(new Actor("farmer"));
            cast.Add(new Actor("fox"));
            cast.Add(new Actor("goose"));
            cast.Add(new Actor("corn"));
        }

        public string getAllPositions()
        {
            StringBuilder sb = new StringBuilder();
            cast.ForEach(role => sb.Append(role.getPosition()));
            return sb.ToString();
        }

        public string getCast()
        {
            StringBuilder sb = new StringBuilder();
            cast.ForEach(role => sb.Append(role.Name + " "));
            return sb.ToString();
        }

        public Boolean isValidCastMember(string name)
        {
            foreach(var role in cast)
            {
                if(role.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        public string getCastMemberPosition(string name)
        {
            foreach (var role in cast)
            {
                if (role.Name.Equals(name))
                {
                    return role.getPosition();
                }
            }
            return string .Format("Don't know where {0} is",name);
        }

    }
}
