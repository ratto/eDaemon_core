using System.Collections.Generic;
using eDaemon_core.Entities.Equipment.Enums;

namespace eDaemon_core.Entities.Equipment
{
    class Weapon : Equipment
    {
        public int Initiative { get; set; }
        public int MinReach { get; set; }
        public int MaxReach { get; set; }
        List<WpnDamageType> WpnDamage = new List<WpnDamageType>();

        public Weapon()
        {

        }
        public Weapon(string name, int initiative)
        {
            Name = name;
            Initiative = initiative;
        }

        public void InsertDamage(DamageType damageType, int minDamage, int maxDamage)
        {
            
        }
    }
}
