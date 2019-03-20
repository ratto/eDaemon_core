using eDaemon_core.Entities.Magic.Enums;
using System.Collections.Generic;

/**
 * Magic features are not fully covered in Daemon 
 * core rules. You need to get some addicional 
 * complement books (like Arkanum) to have access to
 * the campaign's spell and ritual lists.
 * For eDaemon we use the basic magic rules in 
 * both core book and Arkanum rules.
 * There are two types of magic: instant spellcasting 
 * and complicated rituals.
 **/

namespace eDaemon_core.Entities.Magic
{
    abstract class Magic
    {
        private int _id;
        public string Name { get; set; }
        public Form MagicForm { get; set; }
        public int MPCost { get; set; }
        public string Description { get; set; }
        HashSet<Path> MagicPath = new HashSet<Path>();

        public Magic()
        {

        }
    }
}
