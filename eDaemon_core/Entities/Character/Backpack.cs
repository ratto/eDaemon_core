using System.Collections.Generic;
using eDaemon_core.Entities.Equipment;
using eDaemon_core.Entities.Item;

namespace eDaemon_core.Entities.Character
{
    class Backpack
    {
        List<Equipment.Equipment> equip = new List<Equipment.Equipment>();
        List<Item.Item> item = new List<Item.Item>();

        public Backpack()
        {

        }

        public void AddEquip(Equipment.Equipment equipment)
        {
            equip.Add(equipment);
        }
        public void RemoveEquip(Equipment.Equipment equipment)
        {
            equip.Remove(equipment);
        }
        public void AddItem(Item.Item item)
        {
            this.item.Add(item);
        }
        public void RemoveItem(Item.Item item)
        {
            this.item.Remove(item);
        }
    }
}
