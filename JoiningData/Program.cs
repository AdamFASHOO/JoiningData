namespace JoiningData
{
    public class Program
    {
        public static void Main()
        {
            List<Order> Orders = new List<Order>();

            Order a = new AcmeHardware("Acme Hardware", "Mouse", 25, 3);
            Order b = new AcmeHardware("Acme Hardware", "Keyboard", 45, 2);
            Order c = new FallsRealty("Falls Realty", "Macbook", 800, 2);
            Order d = new JuliesMorningDiner("Julie's Morning Diner", "iPad", 525, 1);
            Order e = new JuliesMorningDiner("Julie's Morning Diner", "Credit-Card-Reader", 45, 1);

            Order x = new("", "", 0, 0);

            Orders.Add(a);
            Orders.Add(b);
            Orders.Add(c);
            Orders.Add(d);
            Orders.Add(e);

            Orders.ToArray();

            string lastCustomer = "";
            float lastTotal = 0;

            bool runAgain = true;
            while (runAgain)
            {
                foreach (Order o in Orders)
                {
                    string currentCustomer = o.CustomerName;
                    float total = o.Price * o.Quantity;
                    if (currentCustomer != lastCustomer)
                    {
                        if (currentCustomer == "Falls Realty")
                        {
                            o.PrintHeader(o, currentCustomer);
                            Console.WriteLine("Total: $" + total);
                            Console.WriteLine();
                            Console.WriteLine("Grand Total: $"+total+"\n");
                            Console.ReadKey();

                            lastTotal = total;
                            lastCustomer = currentCustomer;
                        }
                        else
                        {
                        o.PrintHeader(o, currentCustomer);
                        Console.WriteLine("Total: $" + total);

                        lastTotal = total;
                        lastCustomer = currentCustomer;

                        }
                    }
                    else
                    {
                        Console.WriteLine($"{o.Item}/${o.Price}/{o.Quantity}");
                        Console.WriteLine($"Total: ${total}");
                        Console.WriteLine();
                        Console.WriteLine("Grand Total: $" + (total+lastTotal)+"\n");
                        Console.ReadKey();
                    }
                    Console.WriteLine();
                }
                runAgain = x.RunAgain();
            }
        }
    }
}
