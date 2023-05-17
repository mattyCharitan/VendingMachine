using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FactoryMethod.Memento
{
    public class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return mementos[index];
        }

        public List<Memento> GetAllMementos()
        {
            return mementos;
        }

    }
}
