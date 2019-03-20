/**
 * This is the core for any character sheet (for players and NPC)
 * It has every character information in this class
 **/

namespace eDaemon_core
{
    class Character
    {
        // Basic character information
        public string Name { get; }
        public int Level { get; set; }
        public double ExperiencePoints { get; set; }
        public int HitPointTotal { get; set; }
        public int HitPointCurrent { get; set; }
        public int Age { get; set; }

        // We use the CharAttribute class to store each attribute value
        CharAttribute attribute = new CharAttribute();

        public Character()
        {

        }
    }
}
