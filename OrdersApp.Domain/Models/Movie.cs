using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Domain.Models
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
    }
}
