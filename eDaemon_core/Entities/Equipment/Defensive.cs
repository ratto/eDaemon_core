using System.Collections.Generic;
using eDaemon_core.Entities.Equipment.Enums;

namespace eDaemon_core.Entities.Equipment
{
    class Defensive : Equipment
    {
        public int DexPenalty { get; set; }
        public int AgiPenalty { get; set; }
        List<PIType> ProtectionIndex = new List<PIType>();

        public Defensive()
        {

        }
        public Defensive(string name, int dexPenalty, int agiPenalty)
        {
            Name = name;
            DexPenalty = dexPenalty;
            AgiPenalty = agiPenalty;
        }

        public void AddPI(PIType protection)
        {
            ProtectionIndex.Add(protection);
        }
        public void RemovePI(PIType protection)
        {
            ProtectionIndex.Remove(protection);
        }
    }
}
