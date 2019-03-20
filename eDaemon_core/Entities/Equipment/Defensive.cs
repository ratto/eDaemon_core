using System.Collections.Generic;
using eDaemon_core.Entities.Equipment.Enums;

namespace eDaemon_core.Entities.Equipment
{
    class Defensive : Equipment
    {
        public int DexPenalty { get; set; }
        public int AgiPenalty { get; set; }


        public Defensive()
        {

        }
        public Defensive(string name, int dexPenalty, int agiPenalty)
        {
            Name = name;
            DexPenalty = dexPenalty;
            AgiPenalty = agiPenalty;
        }

        public void InsertPI(DamageType pitype, int pivalue)
        {
            
        }
    }
}
