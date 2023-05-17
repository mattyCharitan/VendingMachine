using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.FactoryMethod.Memento;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod
{
    public class ReportFactory
    {
        //collects the data from memento and returns it to who ever is asking for it
        private CareTaker caretaker;
        public ReportFactory(CareTaker caretaker) 
        {
            this.caretaker = caretaker;
        }

        public List<StateClass> GetStates()
        {
            List<StateClass> states = new List<StateClass>();
            foreach (MementoClass m in caretaker.GetAllMementos())
            {
                states.Add(m.state);
            }

            return states;
        }

        public void CreateTextReport()
        {
            TextReport report = new TextReport();
            report.GenerateReport(GetStates());
        }

    }
}
