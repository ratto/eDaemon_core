using eDaemon_core.Entities.Global.Enums;

namespace eDaemon_core.Entities
{
    abstract class Dice
    {
        public Side Side { get; set; }
        public int Rolls { get; set; }
        public int Bonus { get; set; }

        public Dice(Side sides, int rolls, int bonus)
        {
            Side = sides;
            Rolls = rolls;
            Bonus = bonus;
        }

        public int RollDice()
        {
            return 0;
        }
    }
}
