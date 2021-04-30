using System;
using System.Collections.Generic;
using System.Text;
using FixacaoOrder.Entities.Enums;
using FixacaoOrder.Entities;
namespace FixacaoOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
    }
}
