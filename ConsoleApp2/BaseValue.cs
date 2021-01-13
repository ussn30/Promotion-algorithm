using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    // open and closed principle
    public class BaseCalc
    {
        public virtual int GetBaseCalc(int value, int amount)
        {
            return value * amount;
        }
    }

    public class ScenarioACalc : BaseCalc
    {
        public override int GetBaseCalc(int value, int amount)
        {
            BaseAmount scenarioA = new ScenarioA();
            return (value / 3) * 130 + (value % 3 * amount);
        }
    }
    public class ScenarioBCalc : BaseCalc
    {
        public override int GetBaseCalc(int value, int amount)
        {

            return (value / 2) * 45 + (value % 2 * amount);
        }
    }

}
