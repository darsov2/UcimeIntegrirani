using Microsoft.EntityFrameworkCore;
using OrdersApp.Domain.Models;
using OrdersApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Repository.Impl
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<OrdersAppUser> users;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            users = _context.Users;
        }

        public IEnumerable<OrdersAppUser> GetAll()
        {
            return users.AsEnumerable();
        }

        public OrdersAppUser GetById(string id)
        {
            return users.Include(x => x.ShoppingCart)
                .ThenInclude(x => x.Items)
                .FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
