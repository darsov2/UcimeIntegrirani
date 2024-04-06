using OrdersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Service.Interface
{
    public interface IUserService
    {
        OrdersAppUser GetUserById(string id);

    }
}
