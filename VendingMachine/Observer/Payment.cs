using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.State;

namespace VendingMachine.Observer
{
    public class Payment
    {
        Purchase purchase;
       


        public Payment(Purchase purchase)
        {
            this.purchase = purchase;
            
        }

        public decimal pay(decimal amount)
        {
            
            return amount - purchase.product.Price  ;
        }



        
    }
}
