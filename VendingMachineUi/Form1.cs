using System.IO.Packaging;
using System.Windows.Forms;
using VendingMachine;
using VendingMachine.Decorator;
using VendingMachine.State;

namespace VendingMachineUi
{
    public partial class sugarAmount : Form
    {

        private VendingMachineClass vendingMachine;
        decimal amount;
        bool money;
        bool package;
        private int sugarInt=-1;
        private int coffeeInt=-1;
        private int cocoaInt = -1;
        public sugarAmount(VendingMachineClass vendingMachine)
        {
            this.vendingMachine = vendingMachine;
            InitializeComponent();
            pay.Enabled = false;
            bag.Enabled = false;
            gift.Enabled = false;
            confirm.Enabled = false;
            OKAmount.Enabled = false;
            cocoaAm.Enabled = false;
            coffieAm.Enabled = false;
            sugarAm.Enabled = false;


        }


        private void chips_Click(object sender, EventArgs e)
        {
           
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("chips");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;
                
            }

        }

        private void Pretzels_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Pretzels");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }

        }

        private void nuts_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Nuts");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }

        }

        private void cookies_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Cookies");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }

        }

        private void popcorn_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Popcorn");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }

        }

        private void icedTea_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Iced Tea");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }
        }

        private void orangeSoda_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Orange Soda");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }

        }

        private void lemonade_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Lemonade");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }

        }

        private void cola_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Cola");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }

        }

        private void fruitPunch_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Fruit Punch");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                confirm.Enabled = true;

            }
        }



        private void coffee_Click(object sender, EventArgs e)
        {
            confirm.Enabled = false;
            OKAmount.Enabled= true;
            
            coffieAm.Enabled = true;
            sugarAm.Enabled = true;
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("coffee");
                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}₪" +
                        $"\r\nenter num of sugar tsp,coffee tsp";
                    vendingMachine.purchase.product = p;

                }




            }
        }


        private void chocolateMilk_Click(object sender, EventArgs e)
        {
            confirm.Enabled = false;
            OKAmount.Enabled = true;
            cocoaAm.Enabled = true;
            
            sugarAm.Enabled = true;
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Chocolate Milk");
                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}₪" +
                        $"\r\nenter num of sugar tsp,cocoa tsp";
                    vendingMachine.purchase.product = p;
                }
                
            }
        }

        private void hotMilk_Click(object sender, EventArgs e)
        {

            confirm.Enabled = false;
            OKAmount.Enabled = true;
            sugarAm.Enabled = true; 
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Hot Milk");
                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}₪" +
                        $"\r\nenter num of sugar tsp";
                    vendingMachine.purchase.product = p;
                }

               
               
            }
        }

        private void tea_Click(object sender, EventArgs e)
        {
            confirm.Enabled = false;
            OKAmount.Enabled = true;
            sugarAm.Enabled = true;
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("Tea");
                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}₪" +
                        $"\r\nenter num of sugar tsp";
                    vendingMachine.purchase.product = p;
                }
            }
        }
        private void sugarAm_TextChanged(object sender, EventArgs e)
        {
            string sugarAmount = sugarAm.Text;

            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                if (int.TryParse(sugarAm.Text, out sugarInt))
                {
                    screen.Text = $"{sugarInt}";
                }
               
            }
        }

        private void cocoaAm_TextChanged(object sender, EventArgs e)
        {
          



            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                if (int.TryParse(cocoaAm.Text, out cocoaInt))
                {
                    screen.Text = $"{cocoaInt}";
                }
              
            }
        }

        private void coffieAm_TextChanged(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                if (int.TryParse(coffieAm.Text, out coffeeInt))
                {
                    screen.Text = $"{coffeeInt}";
                }
                
            }
           

        }

        private void gift_Click(object sender, EventArgs e)
        {
            if (vendingMachine.purchase.currentState.GetStateName() == "PackagingState")
            {
                vendingMachine.purchase.product = new GiftDecorator(vendingMachine.purchase.product);
                screen.Text = $"total price: {vendingMachine.purchase.product.Price}";
                vendingMachine.purchase.SetState(new PaymentState(vendingMachine.purchase));
                pay.Enabled = true;
            
            }
        }

        private void bag_Click(object sender, EventArgs e)
        {

            if (vendingMachine.purchase.currentState.GetStateName() == "PackagingState")
            {
                vendingMachine.purchase.product = new BagDecorator(vendingMachine.purchase.product);
                screen.Text = $"total price: {vendingMachine.purchase.product.Price}";
                vendingMachine.purchase.SetState(new PaymentState(vendingMachine.purchase));
                pay.Enabled = true;
            }
        }


        private async void pay_Click(object sender, EventArgs e)
        {
            
            if (vendingMachine.purchase.currentState is PaymentState paymentState)
            {
                if (money)
                {
                    screen.Text = $"Your change is {paymentState.p.pay(amount)}";
                    vendingMachine.paid = true;
                    amount = 0;

                    await Task.Delay(2000);

                    if (vendingMachine.paid)
                    {
                        Product p = vendingMachine.SearchProductByName(vendingMachine.purchase.product.Name);
                        vendingMachine.DecreaseQuantity(p);
                        screen.Text = $"Enjoy your {vendingMachine.purchase.product.Name}";
                        money = false;
                        package = false;
                        Package.Checked = false;
                        await Task.Delay(1500);
                        amountMoney.Text = "";
                        pay.Enabled = false;
                        bag.Enabled = false;
                        gift.Enabled = false;
                        confirm.Enabled = false;
                        OKAmount.Enabled = false;
                        cocoaAm.Enabled = false;
                        coffieAm.Enabled = false;
                        sugarAm.Enabled = false;
                        sugarAm.Text = "";
                        cocoaAm.Text = "";
                        coffieAm.Text = "";
                        screen.Text = "Choose a product:";
                        vendingMachine.purchase.SetState(new ChoosingState(vendingMachine.purchase));
                        amountMoney.Text = "";
                    }
                }


            }
        }


       

        

      

        private void screen_TextChanged(object sender, EventArgs e)
        {

        }

        private async void amountMoney_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(amountMoney.Text, out decimal enteredAmount))
            {
                amount += enteredAmount;


                if (amount < vendingMachine.purchase.product.Price)
                {
                    screen.Text = $"Enter more {vendingMachine.purchase.product.Price - amount}";
                    await Task.Delay(900);
                    amountMoney.Text = string.Empty;
                }
                if (amount >= vendingMachine.purchase.product.Price)
                {
                    money = true;
                    pay.Enabled = true;
                    amountMoney.Text = string.Empty;
                    screen.Text = $"you entered {amount}";
                }
            }
           
        }

        private void Package_CheckedChanged(object sender, EventArgs e)
        {
            if (Package.Checked)
            {
                package = true;
            }

        }

        private void confirm_Click(object sender, EventArgs e)
        { 
            if (vendingMachine.purchase.product != null) {
                if (package)
                {
                    vendingMachine.purchase.SetState(new PackagingState(vendingMachine.purchase));
                    bag.Enabled = true;
                    gift.Enabled = true;
                }
                else
                {
                    vendingMachine.purchase.SetState(new PaymentState(vendingMachine.purchase));
                   
                }
                screen.Text = $"enter {vendingMachine.purchase.product.Price}";
            }
        }

        private void OKAmount_Click(object sender, EventArgs e)
        {
            if(vendingMachine.purchase.product.Name == "Coffee")
            {
                if (sugarInt != -1 && coffeeInt != -1)
                {
                    CoffeeBuilder c = new CoffeeBuilder(sugarInt, coffeeInt);
                    vendingMachine.purchase.product = new HotDrink(c, (Drink)(vendingMachine.purchase.product));
                    screen.Text = "coffee prepered";                   
                    sugarInt = -1;
                    coffeeInt = -1;
                    confirm.Enabled = true;

                }
            }
            if (vendingMachine.purchase.product.Name == "Chocolate Milk")
            {
                if (sugarInt != -1 && cocoaInt != -1)
                {
                    ChocolateMilkBuilder c = new ChocolateMilkBuilder(sugarInt, cocoaInt);
                    vendingMachine.purchase.product = new HotDrink(c, (Drink)(vendingMachine.purchase.product));
                    screen.Text = "Chocolate Milk prepered";
                    sugarInt = -1;
                    cocoaInt = -1;
                    confirm.Enabled = true;

                }
            }
            if (vendingMachine.purchase.product.Name == "Hot Milk")
            {
                if (sugarInt != -1)
                {
                    HotMilkBuilder c = new HotMilkBuilder(sugarInt);
                    vendingMachine.purchase.product = new HotDrink(c, (Drink)(vendingMachine.purchase.product));
                    screen.Text = "Hot Milk prepered";
                    sugarInt = -1;
                    confirm.Enabled = true;

                }
            }
            if (vendingMachine.purchase.product.Name == "Tea")
            {
                if (sugarInt != -1)
                {
                    TeaBuilder c = new TeaBuilder(sugarInt);
                    vendingMachine.purchase.product = new HotDrink(c, (Drink)(vendingMachine.purchase.product));
                    screen.Text = "Tea prepered";
                    sugarInt = -1;
                    confirm.Enabled = true;

                }
            }


        }

        
    }
}