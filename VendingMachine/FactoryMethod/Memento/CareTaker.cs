using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FactoryMethod.Memento
{
    public class CareTaker
    {
        private List<MementoClass> mementos = new List<MementoClass>();

        public void AddMemento(MementoClass memento)
        {
            mementos.Add(memento);
        }

        public MementoClass GetMemento(int index)
        {
            return mementos[index];
        }

        public List<MementoClass> GetAllMementos()
        {
            return mementos;
        }

    }
}
