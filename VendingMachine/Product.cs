using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Product
    {
        
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual decimal GetCost()
        {
            return this.Price;
        }


    }
}
