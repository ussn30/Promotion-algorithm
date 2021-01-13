using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class BaseAmount
    {
        public virtual int GetPriceAmount()
        {
            // as of now 0 later we can chnage any amount
            return 0;
        }

    }

    public class ScenarioA : BaseAmount
    {
        public override int GetPriceAmount()
        {
            return base.GetPriceAmount() + 50;
        }
    }
    public class ScenarioB : BaseAmount
    {
        public override int GetPriceAmount()
        {
            return base.GetPriceAmount() + 30;
        }
    }
    public class ScenarioC : BaseAmount
    {
        public override int GetPriceAmount()
        {
            return base.GetPriceAmount() + 20;
        }
    }
    public class ScenarioD : BaseAmount
    {
        public override int GetPriceAmount()
        {
            return base.GetPriceAmount() + 15;
        }
    }
}


