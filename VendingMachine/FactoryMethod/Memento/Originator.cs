using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.State;

namespace VendingMachine.FactoryMethod.Memento
{
    public class Originator
    {
        private MementoClass memento;
        private CareTaker taker;

        public Originator(CareTaker taker)
        {
            this.taker = taker;
        }

        

        public void CreateMemnto() 
        {
            Console.WriteLine("Originator: Creating Memento");
            taker.AddMemento(memento);
            
        }

    }
}
