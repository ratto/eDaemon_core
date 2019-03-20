

namespace eDaemon_core.Entities.Character
{
    class Enhancement
    {
        public int Name { get; set; }
        public int Cost { get; set; }
        public int AttributeBonus { get; set; }
        public int DiceBonus { get; set; }
        public string Description { get; set; }

        public Enhancement()
        {

        }
        public Enhancement(int name, int cost, int attributeBonus, int diceBonus, string description)
        {
            Name = name;
            Cost = cost;
            AttributeBonus = attributeBonus;
            DiceBonus = diceBonus;
            Description = description;
        }
    }
}
