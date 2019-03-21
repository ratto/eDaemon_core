using System.Collections.Generic;

namespace eDaemon_core.Entities.Equipment
{
    class Weapon : Equipment
    {
        public int Initiative { get; set; }
        public int MinReach { get; set; }
        public int MaxReach { get; set; }
        public WeaponType Type { get; set; }
        public List<WpnDamage> WpnDamage = new List<WpnDamage>();

        public Weapon()
        {

        }
        public Weapon(string name, int initiative)
        {
            Name = name;
            Initiative = initiative;
        }
        public Weapon(int initiative, int minReach, int maxReach)
        {
            Initiative = initiative;
            MinReach = minReach;
            MaxReach = maxReach;
        }

        public void AddDamage(WpnDamage damage)
        {
            WpnDamage.Add(damage);
        }
        public void RemoveDamage(WpnDamage damage)
        {
            WpnDamage.Remove(damage);
        }
    }
}
