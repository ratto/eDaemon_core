using System;
using System.Collections.Generic;
using System.Text;
using eDaemon_core.Entities.Equipment.Enums;

namespace eDaemon_core.Entities.Equipment
{
    class WpnDamageType
    {
        public DamageType DamageType { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public WpnDamageType()
        {

        }
        public WpnDamageType(DamageType damageType, int minDamage, int maxDamage)
        {
            DamageType = damageType;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
