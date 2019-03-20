using System;
using System.Collections.Generic;
using System.Text;

namespace eDaemon_core.Entities.Equipment
{
    class Armor
    {
        public string Name { get; set; }
        public int ProtectIndex { get; set; }
        public int DexPenalty { get; set; }
        public int AgiPenalty { get; set; }

        public Armor()
        {

        }
        public Armor(string name, int protectIndex, int dexPenalty, int agiPenalty)
        {
            Name = name;
            ProtectIndex = protectIndex;
            DexPenalty = dexPenalty;
            AgiPenalty = agiPenalty;
        }
    }
}
