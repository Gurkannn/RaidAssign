namespace RaidAssign.Data
{
    public class ToonClass
    {
        public Classes Class { get; set; }
        public Role CharacterRole { get; set; }

        public ToonClass(Classes Class, Role CharacterRole)
        {
            this.Class = Class;
            this.CharacterRole = CharacterRole;
        }
    }

    public enum Role
    {
        Healer,
        Tank,
        Dps
    }

    public enum Classes
    {
        Warrior,
        Druid,
        Shaman,
        Priest,        
        Paladin,
        Rogue,
        Warlock,
        Mage,
        Hunter
    }
}