/**
 * this class wil store and help retrieve the
 * correct attribute score. We will store the original
 * values (given at character creation) and item, race,
 * temporary and other attribute changes that may happen.
 **/

namespace eDaemon_core.Entities.Character
{
    class CharAttribute
    {
        // Each of the following attributes measures...
        public int Strength { get; set; } // ... physical strength
        public int Agility { get; set; } // ... the hands speed and accuracy
        public int Dexterity { get; set; } // ... the body's speed and flexibility
        public int Constitution { get; set; } // ... how big you are
        public int Intelligence { get; set; } // ... how smart and fast witted the character is
        public int WillPower { get; set; } // ... the spiritual and mind constitution
        public int Perception { get; set; } // ... how perceptive your character is
        public int Charisma { get; set; } // ... how well can you interact with NPC

        // These are item and equipment attribute bonus
        public int StrEquipEnhancement { get; set; }
        public int AgiEquipEnhancement { get; set; }
        public int DexEquipEnhancement { get; set; }
        public int ConsEquipEnhancement { get; set; }
        public int IntEquipEnhancement { get; set; }
        public int WillEquipEnhancement { get; set; }
        public int PerEquipEnhancement { get; set; }
        public int ChaEquipEnhancement { get; set; }

        // These are advantage/disadvantage buff/debuff
        public int StrAdvEnhancement { get; set; }
        public int AgiAdvEnhancement { get; set; }
        public int DexAdvEnhancement { get; set; }
        public int ConsAdvEnhancement { get; set; }
        public int IntAdvEnhancement { get; set; }
        public int WillAdvEnhancement { get; set; }
        public int PerAdvEnhancement { get; set; }
        public int ChaAdvEnhancement { get; set; }

        public CharAttribute()
        {

        }

        public CharAttribute(int strength, int agility, int dexterity, int constitution, 
            int intelligence, int willPower, int perception, int charisma)
        {
            Strength = strength;
            Agility = agility;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            WillPower = willPower;
            Perception = perception;
            Charisma = charisma;
        }
    }
}
