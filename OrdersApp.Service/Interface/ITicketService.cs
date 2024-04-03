using OrdersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Service.Interface
{
    public interface ITicketService
    {
        ICollection<Ticket> GetAll();
        Ticket GetById(Guid id);
        Ticket Add(Ticket ticket);
        Ticket Update(Ticket ticket);
        Ticket Delete(Ticket ticket);
    }
}
