using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FactoryMethod.Memento
{
    public class CareTaker
    {
        private List<Memento> history;
        private int currState = -1;

        public CareTaker()
        {
            history = new List<Memento>();
        }

        public void addMemento(Memento memento)
        {
            this.history.Add(memento);
            currState = this.history.Count;

        }

        public Memento getMemento(int index)
        {
            return this.history[index];
        }




    }
}
