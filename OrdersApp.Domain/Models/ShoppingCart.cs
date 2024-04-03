using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Domain.Models
{
    public class ShoppingCart : BaseEntity
    {
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public virtual ICollection<OrderItem> Items { get; set; }
        public OrdersAppUser User { get; set; }
        public string OrdersAppUserId { get; set; }
    }
}
