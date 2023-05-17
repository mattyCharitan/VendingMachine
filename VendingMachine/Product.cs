using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Product
    {
        public string productId;
        public string productName;
        public float price;

        public virtual float GetCost()
        {
            return price;
        }

        //public virtual string Wrapper();
        
    }
}
