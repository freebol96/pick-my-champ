using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickMyChamp.Model
{
    /// <summary>
    /// Class to contain Champion. Currently only holds user-defined Roles or PlayStyles for that Champion as well as a simple name
    /// </summary>
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
}
