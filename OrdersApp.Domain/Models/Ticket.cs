using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Domain.Models
{
    public class Ticket : BaseEntity
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public virtual Movie? Movie { get; set; }
        public Guid MovieId { get; set; }
    }
}
