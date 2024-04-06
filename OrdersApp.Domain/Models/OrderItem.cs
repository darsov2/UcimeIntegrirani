using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Domain.Models
{
    public class OrderItem : BaseEntity
    {
        public virtual Order? Order { get; set; }
        public Guid? OrderId { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
        public virtual ShoppingCart? ShoppingCart { get; set; }
        public Guid? ShoppingCartId { get; set; }
    }
}
