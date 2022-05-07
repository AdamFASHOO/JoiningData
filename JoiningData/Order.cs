using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningData
{
    class Order
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public Order(string CustomerName, string Item, float Price, int Quantity)
        {
            this.CustomerName = CustomerName;
            this.Item = Item;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public void PrintHeader(Order currentOrder, string currentCustomer)
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"{currentCustomer}");
            Console.WriteLine("=========================");
            Console.WriteLine("Item/Price/Quantity:\n");
            Console.WriteLine($"{currentOrder.Item}/${currentOrder.Price}/{currentOrder.Quantity}");
        }
     
        public bool RunAgain()
        {
            Console.WriteLine("Would you like to run the program again? y/n");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand that...");
                return RunAgain();
            }
        }


        //public void CustomerLooper(List<Order> orders)
        //{
        //    string lastCustomer = "";
        //    bool runAgain = true;
        //    while (runAgain)
        //    {
        //        foreach (Order o in orders)
        //        {
        //            string currentCustomer = o.CustomerName;
        //            if (currentCustomer != lastCustomer)
        //            {
        //                o.PrintHeader(o, currentCustomer);
        //                lastCustomer = currentCustomer;
        //            }
        //            else
        //            {
        //                o.PrintHeader2(o);
        //            }
        //        }
        //        runAgain = false;
        //    }
        //}
    }
}
