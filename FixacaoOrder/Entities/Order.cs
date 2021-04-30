using System;
using System.Collections.Generic;
using System.Text;
using FixacaoOrder.Entities.Enums;
namespace FixacaoOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public Order()
        {

        }

    }
}
