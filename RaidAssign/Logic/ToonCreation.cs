using RaidAssign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssign.Logic
{
    public class ToonCreation
    {
        public Toon CreateCharacter(string name, ToonClass characterClass)
        {
            Toon newChar = new Toon(name,characterClass);
            return newChar;
        }
    }
}
