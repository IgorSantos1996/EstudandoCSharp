using System;
using System.Collections.Generic;
using System.Text;

namespace Composition03.Entities
{
    class OrderItem
    {
        public int Quantify { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantidade, double price, Product produto)
        {
            Quantify = quantidade;
            Price = price;
            Products = produto;
        }

        public double SubTotal()
        {
            return Price * Quantify;
        }

    }
}
