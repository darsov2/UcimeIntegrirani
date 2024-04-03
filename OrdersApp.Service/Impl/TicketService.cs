using OrdersApp.Domain.Models;
using OrdersApp.Repository.Interface;
using OrdersApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Service.Impl
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> _ticketRepository;
        public Ticket Add(Ticket ticket)
        {
            return _ticketRepository.Add(ticket);
        }

        public Ticket Delete(Ticket ticket)
        {
            return _ticketRepository.Delete(ticket);
        }

        public ICollection<Ticket> GetAll()
        {
            return _ticketRepository.GetAll().ToList();
        }

        public Ticket GetById(Guid id)
        {
            return _ticketRepository.GetById(id); 
        }

        public Ticket Update(Ticket ticket)
        {
            return _ticketRepository.Update(ticket);
        }
    }
}
