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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public OrdersAppUser GetUserById(string id)
        {
            return _userRepository.GetById(id);
        }
    }
}
