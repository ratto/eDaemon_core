using System.Collections.Generic;

/**
 * This is the core for any character sheet (for players and NPC)
 * It has every character information in this class
 **/

namespace eDaemon_core.Entities.Character
{
    class Character
    {
        // Basic character information
        public string Name { get; private set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public double ExperiencePoints { get; set; }
        public int HPTotal { get; set; } // Hit Points Total score
        public int HPCurrent { get; set; } // Hit Points Current score
        public int HeroPoints { get; set; }
        public int SPTotal { get; set; } // Skill points
        public int Iniciativa { get; set; }
        public Backpack CarriedItems { get; set; } // Carried equipment and item
        public Equipped Equip { get; set; }
        public CharAttribute Attribute { get; set; } = new CharAttribute();
        public List<ProtectiveIndex> PI { get; set; } = new List<ProtectiveIndex>();
        public List<Enhancement> Enhancements { get; set; } = new List<Enhancement>();
        public List<CustomSkill> Skill { get; set; } = new List<CustomSkill>();
        public List<WeaponSkill> WpnSkill { get; set; } = new List<WeaponSkill>();

        public Character()
        {

        }

        public Character(string name, int strenght, int agility, int dexterity, int constitution, int intelligence, int willpower, int perception, int charisma)
        {
            // basic information created
            Name = name;
            Attribute.Strength = strenght;
            Attribute.Agility = agility;
            Attribute.Dexterity = dexterity;
            Attribute.Constitution = constitution;
            Attribute.Intelligence = intelligence;
            Attribute.WillPower = willpower;
            Attribute.Perception = perception;
            Attribute.Charisma = charisma;

            // now we will fill the rest of the sheet data
            HPTotal = (Attribute.Strength + Attribute.Constitution) / 2;
            HPCurrent = HPTotal;

        }

        public void AddProtectiveIndex(ProtectiveIndex pi)
        {
            PI.Add(pi);
        }
        public void RemoveProtectiveIndex(ProtectiveIndex pi)
        {
            PI.Remove(pi);
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            Enhancements.Add(enhancement);
        }

        public void RemoveEnhancement(Enhancement enhancement)
        {
            Enhancements.Remove(enhancement);
        }

        public void AddCustomSkill(CustomSkill skill)
        {
            Skill.Add(skill);
        }

        public void RemoveSkill(CustomSkill skill)
        {
            Skill.Remove(skill);
        }

        public void AddWpnSkill(WeaponSkill wpnskill)
        {
            WpnSkill.Add(wpnskill);
        }

        public void RemoveWpnSkill(WeaponSkill wpnskill)
        {
            WpnSkill.Remove(wpnskill);
        }

        public void Attack(Character target)
        {
            int hitChance = 0;
            int attackHitChance = 0;
            int defenseChance = target.Defend();

            if (Equip.Arm[0] != null && Equip.Arm[1].Type == WeaponType.Shield || Equip.Arm[1] == null)
            {
                foreach (WeaponSkill wpnskill in WpnSkill)
                {
                    if (Equip.Arm[0].Name == wpnskill.Name)
                    {
                        attackHitChance = wpnskill.TotalAttackBonus();
                    }
                    else
                    {
                        attackHitChance = Attribute.Dexterity * 4;
                    }
                }
            }
            else if (Equip.Arm[0].Type == WeaponType.Shield || Equip.Arm[0] == null && Equip.Arm[1] != null)
            {
                foreach (WeaponSkill wpnskill in WpnSkill)
                {
                    if (Equip.Arm[1].Name == wpnskill.Name)
                    {
                        attackHitChance = wpnskill.TotalAttackBonus();
                    }
                    else
                    {
                        attackHitChance = Attribute.Dexterity * 4;
                    }
                }
            }
            else if ((Equip.Arm[0].Type == WeaponType.Shield && Equip.Arm[1] == null) || (Equip.Arm[0] == null && Equip.Arm[1].Type == WeaponType.Shield))
            {
                foreach (WeaponSkill wpnskill in WpnSkill)
                {
                    if ("Shield" == wpnskill.Name)
                    {
                        attackHitChance = wpnskill.TotalAttackBonus();
                    }
                    else
                    {
                        attackHitChance = Attribute.Dexterity * 4;
                    }
                }
            }
            else
            {
                foreach (WeaponSkill wpnskill in WpnSkill)
                {
                    if ("Fighting" == wpnskill.Name)
                    {
                        hitChance += wpnskill.TotalAttackBonus();
                    }
                    else
                    {
                        hitChance += Attribute.Agility * 4;
                    }
                }
            }

            hitChance = 50 + attackHitChance + defenseChance;

        }

        /**
         * Each character may try to defend itself in response to
         * an attack. In this defense action we will check wich
         * defensive move is better to use and to apply this chance
         * to the aggressor attack check.
         **/

        public int Defend()
        {
            int defendChance = 0;
            int blockChance = 0;
            int parryChance = 0;
            int dodgeChance = 0;

            // First we will get each defensive action chance value... 
            // Block chance value
            if (Equip.Arm[0].Type == WeaponType.Shield || Equip.Arm[1].Type == WeaponType.Shield)
            {
                foreach (WeaponSkill wpnskill in WpnSkill)
                {
                    if ("Shield" == wpnskill.Name)
                    {
                        blockChance = wpnskill.TotalDefenseBonus();
                    }
                    else
                    {
                        blockChance = Attribute.Dexterity * 4;
                    }
                }
            }

            // Parry chance value
            if ((Equip.Arm[0] != null && Equip.Arm[0].Type != WeaponType.Shield) || (Equip.Arm[1] != null && Equip.Arm[1].Type != WeaponType.Shield))
            {
                int arm_0 = 0;
                int arm_1 = 0;

                foreach (WeaponSkill wpnskill in WpnSkill)
                {
                    if (Equip.Arm[0] != null && Equip.Arm[0].Name == wpnskill.Name)
                    {
                        arm_0 = wpnskill.TotalDefenseBonus();
                    }
                    if (Equip.Arm[1] != null && Equip.Arm[1].Name == wpnskill.Name)
                    {
                        arm_1 = wpnskill.TotalDefenseBonus();
                    }
                }

                if (arm_0 >= arm_1)
                {
                    parryChance = arm_0;
                }
                else
                {
                    parryChance = arm_1;
                }
            }

            // Dodge chance value
            foreach (CustomSkill skill in Skill)
            {
                if ("Evade" == skill.Name)
                {
                    dodgeChance = skill.SkillBonus + (Attribute.Agility * 4);
                }
                else
                {
                    dodgeChance = Attribute.Agility * 4;
                }
            }

            // ... and now we check wich of the defensive actions is better to use
            if (blockChance > parryChance && blockChance > dodgeChance)
            {
                defendChance = blockChance;
            }
            else if (parryChance > dodgeChance)
            {
                defendChance = parryChance;
            }
            else
            {
                defendChance = dodgeChance;
            }

            return defendChance;
        }
    }
}
