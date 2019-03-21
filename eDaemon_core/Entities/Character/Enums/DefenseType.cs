using System;
using System.Collections.Generic;
using System.Text;

namespace eDaemon_core.Entities.Character.Enums
{
    enum DefenseType : int
    {
        Parry, // in case of parrying an attack with your weapon
        Dodge, // in case of trying to evade using Evasion (common)skill or Agility modifier
        Block // in case of blocking an attack with a shield (using Shield (weapon)skill
    }
}
