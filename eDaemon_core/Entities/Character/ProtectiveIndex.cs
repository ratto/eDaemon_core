/**
 * Protective Index is basically the defense of 
 * a character. It is use to reduce taken damage.
 * We can have several PI types, like cinetic
 * type, used for most of medieval weapon defense,
 * or elemental (fire, ice, earth, wind, eletric).
 * PI is used after damage is taken.
 **/

namespace eDaemon_core.Entities.Character
{
    class ProtectiveIndex
    {
        public int Cinetic { get; set; }
        public int Fire { get; set; }
        public int Cold { get; set; }
        public int Earth { get; set; }
        public int Wind { get; set; }
        public int Eletric { get; set; }

        public ProtectiveIndex()
        {

        }
    }
}
