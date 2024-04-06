using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Domain.Models
{
    public class Order : BaseEntity
    {
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
