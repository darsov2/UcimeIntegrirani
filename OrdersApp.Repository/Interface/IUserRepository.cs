using OrdersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<OrdersAppUser> GetAll();
        OrdersAppUser GetById(string id);
    }
}
