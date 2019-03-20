using System;
/**
 * In tabletop Daemon edition we get some values
 * according to the character's attribute he will be 
 * better then other with lower attribute value. 
 * E.g. a character with Strenght score of 15 can 
 * lift about 140kg and a medium character, with 
 * Strenght score of 10, can lift 80kg.
 * Medium attribute score is 10 (normal people range
 * between 5 and 20, depending on campaign style).
 **/

 namespace eDaemon_core.Entities.Global
{
    abstract class CapacityValue
    {
        public double GetCapacytyValue(double conversion, int attribute)
        {
            return conversion*(Math.Pow(2, (attribute/6)));
        }
    }
}
