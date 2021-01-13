using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    // interface segartion
    public class ProductService : IProductService
    {
        public int GetTotalPrice(List<string> items)
        {
            int ACount = 0;
            int BCount = 0;
            int CCount = 0;
            int DCount = 0;
            foreach (var it in items)
            {
                if (it == "A" || it == "a")
                {
                    ACount = ACount + 1;
                }
                if (it == "B" || it == "b")
                {
                    BCount = BCount + 1;
                }
                if (it == "C" || it == "c")
                {
                    CCount = CCount + 1;
                }
                if (it == "D" || it == "d")
                {
                    DCount = DCount + 1;
                }
            }
            /// 

            BaseAmount scenarioA = new ScenarioA();
            BaseAmount scenarioB = new ScenarioB();
            BaseAmount scenarioC = new ScenarioC();
            BaseAmount scenarioD = new ScenarioD();

            BaseCalc scenarioACalc = new ScenarioACalc();
            BaseCalc scenarioBCalc = new ScenarioACalc();
            BaseCalc baseCalc = new BaseCalc();

            int totalofA = scenarioACalc.GetBaseCalc(ACount, scenarioA.GetPriceAmount());
            int totalofB = scenarioBCalc.GetBaseCalc(BCount, scenarioB.GetPriceAmount());
            int totalofC = baseCalc.GetBaseCalc(CCount, scenarioC.GetPriceAmount());
            int totalofD = baseCalc.GetBaseCalc(DCount, scenarioD.GetPriceAmount());
            return totalofA + totalofB + totalofC + totalofD;

        }
    }
}
