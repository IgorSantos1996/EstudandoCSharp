using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Composition03.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantidade, double price, Product produto)
        {
            Quantity = quantidade;
            Price = price;
            Products = produto;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Products.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
