using System;
using System.Collections.Generic;
using System.Text;

namespace FixacaoOrder.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {

        }

        public double SubTotal(int quantity,double price)
        {
            return quantity * price;
        }
    }
}
