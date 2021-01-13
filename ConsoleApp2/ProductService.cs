using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ProductService : IProductService
    {
        public int GetTotalPrice(List<string> products)
        {
            int counterofA = 0;
            int counterofB = 0;
            int CounterofC = 0;

            int CounterofD = 0;

            foreach (var pr in products)
            {
                if (pr == "A" || pr == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr == "B" || pr == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr == "C" || pr == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr == "D" || pr == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            

            BaseAmount scenarioA = new ScenarioA();
            BaseAmount scenarioB = new ScenarioB();
            BaseAmount scenarioC = new ScenarioC();
            BaseAmount scenarioD = new ScenarioD();

            BaseCalc scenarioACalc = new ScenarioACalc();
            BaseCalc scenarioBCalc = new ScenarioACalc();
            BaseCalc baseCalc = new BaseCalc();

            int totalPriceofA = scenarioACalc.GetBaseCalc(counterofA, scenarioA.GetPriceAmount());
            int totalPriceofB = scenarioBCalc.GetBaseCalc(counterofB, scenarioB.GetPriceAmount());
            int totalPriceofC = baseCalc.GetBaseCalc(CounterofC, scenarioC.GetPriceAmount());
            int totalPriceofD = baseCalc.GetBaseCalc(CounterofD, scenarioD.GetPriceAmount());
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
