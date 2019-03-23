/**
 * This class represents default skills used 
 * basically for world interaction. This class 
 * covers skills like swimming, running, knowledge
 * and so on.
 **/

namespace eDaemon_core.Entities.Character
{
    class CustomSkill
    {
        public string Name { get; set; }
        public int AttributeBonus { get; set; }
        public int SkillBonus { get; set; } = 0;
        public int MiscBonus { get; set; } = 0;
        
        public CustomSkill()
        {

        }

        public CustomSkill(string name, int attributeBonus, int skillBonus)
        {
            Name = name;
            AttributeBonus = attributeBonus;
            SkillBonus = skillBonus;
        }
    }
}
