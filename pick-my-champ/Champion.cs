using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomChampPicker
{
    public class Champion
    {
        public List<PlayStyle> Roles { get; private set; }
        public string Name { get; private set; }

        public Champion (string name, List<PlayStyle> designedRoles)
        {
            //some error checking, e.g. both not empty or null
            Name = name;
            Roles = designedRoles;
        }
    }

    public enum PlayStyle
    {
        MARKSMAN,
        TANK,
        SUPPORT,
        MAGE,
        ASSASSIN,
        FIGHTER 
    }
}
