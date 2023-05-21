using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.FactoryMethod.Memento;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod
{
    public abstract class Report
    {
        public abstract void GenerateReport(List<MementoClass> states);
    }
}
