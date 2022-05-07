using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningData
{
    class FallsRealty : Order
    {
        public FallsRealty(string CustomerName, string Item, float Price, int Quantity) : base(CustomerName, Item, Price, Quantity)
        {
            this.CustomerName = CustomerName;
            this.Item = Item;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
