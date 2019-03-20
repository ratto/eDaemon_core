using eDaemon_core.Entities.Equipment;

namespace eDaemon_core.Entities.Character
{
    class Equipped
    {
        public Defensive Head { get; set; } // Helmets, caps and other head gear
        public Defensive Face { get; set; } // Masks, goggles and other facial features 
        public Defensive Torso { get; set; } // Breast plates, shirts and other piece of clothing/armor used on the upper side of the body
        public Defensive Pants { get; set; } // Pants and othe piece of clothing/armor used on the bottom side of the body
        public Defensive Feet { get; set; } // Shoes, sandals and other foot protection gear 

        public Equipped()
        {

        }
    }
}
