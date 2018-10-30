using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssign.Data
{
    public class Toon
    {
        public Toon(string Name, ToonClass characterClass)
        {
            this.Name = Name;
            this.Class = characterClass;
        }
        public Role GetRole { get => Class.CharacterRole; }
        public Classes GetClass { get => Class.Class; }
        public string Name { get; set; }
        public ToonClass Class { get; set; }
    }
}
