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
        public double AttributeModBonus { get; set; }
        public double Bonus { get; set; }
        
        public CustomSkill()
        {

        }
        public CustomSkill(string name, double attribute, double bonus)
        {
            Name = name;
            AttributeModBonus = attribute * 4;
            Bonus = bonus;
        }

        public void UseCustomSkill()
        {

        }
    }
}
