/**
 * In tabletop Daemon rulebook, each character has weapon
 * skills that measures how good a character is in using a
 * certain weapon. E.g. you can use a sword to attack, as 
 * to defend (parrying an attack).
 * Notice that shields are in weapon skill list, as you
 * can use it for defense (blocking) as for offense 
 * (bashing).
 * Bows and other shooting weapons can't use any defense 
 * bonus; they are as good as a small and fragile stick 
 * for defense. It takes twice the default bonus to 
 * enhance a distance type weapon skill.
 **/

namespace eDaemon_core.Entities.Character
{
    class WeaponSkill
    {
        public string Name { get; set; }
        public double AttackBonus { get; set; }
        public double DefenseBonus { get; set; }

        public WeaponSkill()
        {

        }
        public WeaponSkill(string name, double attackBonus, double defenseBonus)
        {
            Name = name;
            AttackBonus = attackBonus;
            DefenseBonus = defenseBonus;
        }
    }
}
