using eDaemon_core.Entities.Equipment.Enums;

namespace eDaemon_core.Entities.Equipment
{
    class WpnDamage
    {
        public DamageType Type { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        
        public WpnDamage()
        {

        }
        public WpnDamage(DamageType type, int minDamage, int maxDamage)
        {
            Type = type;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
