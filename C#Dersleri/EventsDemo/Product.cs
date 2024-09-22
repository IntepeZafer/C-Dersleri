using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public delegate void StockControl();
    internal class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public void Sell(int amount) { 
            Stock -= amount;
            Console.WriteLine("{1} stock amount is {0}", Stock, ProductName);
        }
    }
}
