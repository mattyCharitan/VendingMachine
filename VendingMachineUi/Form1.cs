using System.IO.Packaging;
using VendingMachine;
using VendingMachine.Decorator;
using VendingMachine.State;

namespace VendingMachineUi
{
    public partial class sugarAmount : Form
    {
        private VendingMachineClass vendingMachine;
        public sugarAmount(VendingMachineClass vendingMachine)
        {
            this.vendingMachine = vendingMachine;
            InitializeComponent();
        }
        

        private void chips_Click(object sender, EventArgs e)
        {
            if(vendingMachine.purchase.currentState.GetStateName()  == "ChoosingState")
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
                vendingMachine.purchase.product =new BagDecorator(vendingMachine.purchase.product);
                screen.Text=vendingMachine.purchase.product.ToString();
                screen.Text = "packing";
            }


        }

        private void pay_Click(object sender, EventArgs e)
        {

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
    }
}