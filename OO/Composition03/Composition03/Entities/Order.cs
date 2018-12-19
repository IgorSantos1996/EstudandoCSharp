using System;
using System.Collections.Generic;
using System.Text;
using Composition03.Entities.Enums;
using System.Globalization;

namespace Composition03.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Client = cliente;
        }

        public void Additem(OrderItem o)
        {
            orderItems.Add(o);
        }
        public void Removeitem(OrderItem o)
        {
            orderItems.Remove(o);
        }
        public double total()
        {
            double sum = 0;
            foreach (OrderItem item in orderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in orderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price : $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
