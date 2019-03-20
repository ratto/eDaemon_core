namespace eDaemon_core.Entities.Equipment
{
    class Weapon
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Initiative { get; set; }
        public int MinReach { get; set; }
        public int MaxReach { get; set; }

        public Weapon()
        {

        }
        public Weapon(string name, int minDamage, int maxDamage, int initiative)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Initiative = initiative;
        }

        public Weapon(string name, int minDamage, int maxDamage, int initiative, int minReach, int maxReach)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Initiative = initiative;
            MinReach = minReach;
            MaxReach = maxReach;
        }
    }
}
