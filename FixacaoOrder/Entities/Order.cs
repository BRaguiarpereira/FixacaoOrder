using System;
using System.Collections.Generic;
using System.Text;
using FixacaoOrder.Entities.Enums;
using FixacaoOrder.Entities;
using System.Globalization;
namespace FixacaoOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }
        //Lembra que tem que criar os tipo quando são referenciado
        //exemplo Order esta relacionado com o Client
        public Client Client { get; set; }
        // E caso for uma composiçao cria um tipo list relacionado com a classe em especifico
        // exemplo Order com OrderItem
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        // Metodo total que pega o subtotal dos OrderItem 
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
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
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
