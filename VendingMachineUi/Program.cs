using VendingMachine;
using VendingMachine.Observer;

namespace VendingMachineUi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            VendingMachineClass vendingMachine = new VendingMachineClass();

            #region Initialize Inventory
            //Snacks
            Snack chips = new Snack { Name = "Chips", Price = 2.1m };
            Snack pretzels = new Snack { Name = "Pretzels", Price = 1.8m };
            Snack popcorn = new Snack { Name = "Popcorn", Price = 2.5m };
            Snack cookies = new Snack { Name = "Cookies", Price = 1.5m };
            Snack nuts = new Snack { Name = "Nuts", Price = 3.0m };

            //Cold Drinks
            Drink cola = new Drink { Name = "Cola", Price = 1.5m };
            Drink lemonade = new Drink { Name = "Lemonade", Price = 2.0m };
            Drink orangeSoda = new Drink { Name = "Orange Soda", Price = 1.75m };
            Drink icedTea = new Drink { Name = "Iced Tea", Price = 2.25m };
            Drink fruitPunch = new Drink { Name = "Fruit Punch", Price = 2.5m };
            //hot Drinks
            Drink chocolateMilk = new Drink { Name = "Chocolate Milk", Price = 2.0m };
            Drink coffee = new Drink { Name = "Coffee", Price = 1.5m };
            Drink hotMilk = new Drink { Name = "Hot Milk", Price = 1.75m };
            Drink tea = new Drink { Name = "Tea", Price = 1.25m };

            vendingMachine.supplier.AddQuantity(chips, 10);
            vendingMachine.supplier.AddQuantity(pretzels, 10);
            vendingMachine.supplier.AddQuantity(popcorn, 10);
            vendingMachine.supplier.AddQuantity(cookies, 10);
            vendingMachine.supplier.AddQuantity(nuts, 10);
            vendingMachine.supplier.AddQuantity(cola, 10);
            vendingMachine.supplier.AddQuantity(lemonade, 10);
            vendingMachine.supplier.AddQuantity(orangeSoda, 10);
            vendingMachine.supplier.AddQuantity(icedTea, 10);
            vendingMachine.supplier.AddQuantity(fruitPunch, 10);
            vendingMachine.supplier.AddQuantity(chocolateMilk, 10);
            vendingMachine.supplier.AddQuantity(coffee, 10);
            vendingMachine.supplier.AddQuantity(hotMilk, 10);
            vendingMachine.supplier.AddQuantity(tea, 10);
            #endregion








            ApplicationConfiguration.Initialize();
            Application.Run(new sugarAmount(vendingMachine));
        }
    }
}