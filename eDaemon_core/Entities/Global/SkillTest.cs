using System;

/**
 * This class is called every time there is a skill chalenge.
 * If a character sneaks past guards he will use his Sneak 
 * Skill (or Agility modifier score) against the guard's Spot 
 * Skill (or Perception modifier score) to see if he can pass
 * unoticed by the guards.
 * A standard skill test dificulty is 50 + active source - 
 * passive source. For easy tests the active source is
 * boosted, incrising by it's own score times 2. On the other  
 * hand, for hard tests the active source score is divided by 
 * 2.
 * If the d100 die roll equals or is lower than the dificulty 
 * score the result is successfull. In case that the die roll 
 * equals or is smaller than active source / 4 also means a 
 * success, no matter the dificulty score.
 * The test results in fail if the die result is over the 
 * dificulty score, or if the die roll equals or is over 95, 
 * no matter dificulty score.
 **/

namespace eDaemon_core.Entities.Global
{
    class SkillTest
    {
        public SkillTest()
        {
        }

        public bool StandardSkill(int active, int passive)
        {
            bool testResult = true;
            int testDificulty = 50 + active - passive;

            Random rd = new Random();
            int dieResult = rd.Next(1, 100);
            
            if (dieResult <= testDificulty || dieResult <= active / 4)
            {
                testResult = true;
            }
            else
            {
                testResult = false;
            }

            return testResult;
        }

        public bool EasySkill(int active, int passive)
        {
            bool testResult = true;
            int testDificulty = 50 + (active * 2) - passive;

            Random rd = new Random();
            int dieResult = rd.Next(1, 100);

            if (dieResult <= testDificulty || dieResult <= active / 4)
            {
                testResult = true;
            }
            else
            {
                testResult = false;
            }

            return testResult;
        }

        public bool HardSkill(int active, int passive)
        {
            bool testResult = true;
            int testDificulty = 50 + (active / 2) - passive;

            Random rd = new Random();
            int dieResult = rd.Next(1, 100);

            if (dieResult <= testDificulty || dieResult <= active / 4)
            {
                testResult = true;
            }
            else if (dieResult >= 95)
            {
                testResult = false;
            }
            else
            {
                testResult = false;
            }

            return testResult;
        }
    }
}
