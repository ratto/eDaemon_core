using eDaemon_core.Entities.Item.Enums;

namespace eDaemon_core.Entities.Item
{
    class Item
    {
        private int _id;
        private ItemType _type;
        public string Name { get; set; }

        public Item()
        {

        }
        public Item(int id, ItemType type, string name)
        {
            _id = id;
            _type = type;
            Name = name;
        }
    }
}
