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
        public int AttributeBonus { get; set; }
        public int AttackBonus { get; set; }
        public int DefenseBonus { get; set; }
        public int MiscAtkBonus { get; set; }
        public int MiscDefBonus { get; set; }

        public WeaponSkill()
        {

        }

        public WeaponSkill(string name, int attributeBonus, int attackBonus, int defenseBonus)
        {
            Name = name;
            AttributeBonus = attributeBonus;
            AttackBonus = attackBonus;
            DefenseBonus = defenseBonus;
        }

        public int TotalAttackBonus()
        {
            return AttackBonus + MiscAtkBonus + (AttributeBonus * 4);
        }

        public int TotalDefenseBonus()
        {
            return DefenseBonus + MiscDefBonus + (AttributeBonus * 4);
        }
    }
}
