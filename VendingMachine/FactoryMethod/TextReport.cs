using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod
{
    internal class TextReport : Report
    {
    
        //gets the report from report factory and outputs it to a txt file
        public override void GenerateReport(List<StateClass> states)
        {
            using (StreamWriter writer = new StreamWriter("report.txt"))
            {
                foreach (StateClass state in states)
                {
                    writer.WriteLine(state.GetStateName());
                }
            }

            Console.WriteLine("Text report generated.");

        }
    }
}
