using eDaemon_core.Entities.Equipment.Enums;

namespace eDaemon_core.Entities.Equipment
{
    class PIType
    {
        public DamageType Type { get; set; }
        public int IPValue { get; set; }

        public PIType()
        {

        }
        public PIType(DamageType type, int iPValue)
        {
            Type = type;
            IPValue = iPValue;
        }
    }
}
