using System.Collections.Generic;

/**
 * This is the core for any character sheet (for players and NPC)
 * It has every character information in this class
 **/

namespace eDaemon_core.Entities.Character
{
    class Character
    {
        // Basic character information
        public string Name { get; }
        public int Age { get; set; }
        public int Level { get; set; }
        public double ExperiencePoints { get; set; }
        public int HPTotal { get; set; }
        public int HPCurrent { get; set; }
        public int MPTotal { get; set; }
        public int MPCurrent { get; set; }
        public int HeroPoints { get; set; }
        public int SPTotal { get; set; }

        CharAttribute Attribute = new CharAttribute();
        List<Enhancement> Enhancements = new List<Enhancement>();
        List<CustomSkill> Skill = new List<CustomSkill>();
        List<WeaponSkill> WpnSkill = new List<WeaponSkill>();

        public Character()
        {

        }
        public Character(string name, int strenght, int agility, int dexterity, int constitution, int intelligence, int willpower, int perception, int charisma)
        {
            // basic information created
            Name = name;
            Attribute.Strength = strenght;
            Attribute.Agility = agility;
            Attribute.Dexterity = dexterity;
            Attribute.Constitution = constitution;
            Attribute.Intelligence = intelligence;
            Attribute.WillPower = willpower;
            Attribute.Perception = perception;
            Attribute.Charisma = charisma;

            // now we will fill the rest of the sheet data
            HPTotal = (Attribute.Strength + Attribute.Constitution) / 2;
            HPCurrent = HPTotal;
        }

    }
}
