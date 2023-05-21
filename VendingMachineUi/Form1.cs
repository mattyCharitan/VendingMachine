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
        public sugarAmount(VendingMachineClass vendingMachine)
        {
            this.vendingMachine = vendingMachine;
            InitializeComponent();
        }


        private void chips_Click(object sender, EventArgs e)
        {
            //thre is a problem with the fact that it switches to bag
            if (vendingMachine.purchase.currentState.GetStateName() == "ChoosingState")
            {
                Product p = vendingMachine.SearchProductByName("chips");

                if (p != null)
                {
                    screen.Text = $"{p.Name} {p.Price}$";
                }
                vendingMachine.purchase.product = p;
                vendingMachine.purchase.SetState(new PackagingState(vendingMachine.purchase));
            }

        }

        private void Pretzels_Click(object sender, EventArgs e)
        {

        }

        private void nuts_Click(object sender, EventArgs e)
        {

        }

        private void cookies_Click(object sender, EventArgs e)
        {

        }

        private void popcorn_Click(object sender, EventArgs e)
        {

        }

        private void icedTea_Click(object sender, EventArgs e)
        {

        }

        private void orangeSoda_Click(object sender, EventArgs e)
        {

        }

        private void lemonade_Click(object sender, EventArgs e)
        {

        }

        private void cola_Click(object sender, EventArgs e)
        {

        }

        private void fruitPunch_Click(object sender, EventArgs e)
        {

        }



        private void coffee_Click(object sender, EventArgs e)
        {

        }

        private void chocolateMilk_Click(object sender, EventArgs e)
        {

        }

        private void hotMilk_Click(object sender, EventArgs e)
        {

        }

        private void tea_Click(object sender, EventArgs e)
        {

        }

        private void sugarAm_TextChanged(object sender, EventArgs e)
        {

        }

        private void cocoaAm_TextChanged(object sender, EventArgs e)
        {

        }

        private void coffieAm_TextChanged(object sender, EventArgs e)
        {

        }

        private void gift_Click(object sender, EventArgs e)
        {

        }

        private void bag_Click(object sender, EventArgs e)
        {

            if (vendingMachine.purchase.currentState.GetStateName() == "PackagingState")
            {
                vendingMachine.purchase.product = new BagDecorator(vendingMachine.purchase.product);
                screen.Text = $"total price: {vendingMachine.purchase.product.Price}";
                vendingMachine.purchase.SetState(new PaymentState(vendingMachine.purchase));

            }


        }

        private string previousAmount = string.Empty;

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
                        vendingMachine.DecreaseQuantity(vendingMachine.purchase.product);
                        screen.Text = $"Enjoy your {vendingMachine.purchase.product.Name}";

                        await Task.Delay(1500);
                        amountMoney.Text = "";
                        screen.Text = "Choose a product:";
                        vendingMachine.purchase.SetState(new ChoosingState(vendingMachine.purchase));
                        amountMoney.Text = "";
                    }
                }


            }
        }


        private void sugarOkButton_Click(object sender, EventArgs e)
        {
            string sugarAmount = sugarAm.Text;

            MessageBox.Show($"Sugar Amount: {sugarAmount}");
            sugarAm.Text = string.Empty;
        }

        private void cocoaOkButton_Click(object sender, EventArgs e)
        {
            string cocoaAmount = cocoaAm.Text;
            MessageBox.Show($"cocoa Amount: {cocoaAmount}");
            cocoaAm.Text = string.Empty;
        }

        private void coffieOkButton_Click(object sender, EventArgs e)
        {
            string coffieAmount = coffieAm.Text;
            MessageBox.Show($"coffie Amount: {coffieAmount}");
            coffieAm.Text = string.Empty;
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
                    amountMoney.Text = string.Empty;
                    screen.Text = $"you entered {amount}";



                }
            }
           
        }
    }
}