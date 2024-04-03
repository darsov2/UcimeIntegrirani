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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderItem> _itemRepository;
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;

        public OrderService(IRepository<Order> orderRepository, 
            IRepository<OrderItem> itemRepository,
            IRepository<ShoppingCart> shoppingCartRepository)
        {
            _orderRepository = orderRepository;
            _itemRepository = itemRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public Order Add(Order order)
        {
            return _orderRepository.Add(order);
        }

        public OrderItem Add(OrderItem orderItem)
        {
            return _itemRepository.Add(orderItem);
        }

        public Order Delete(Guid id)
        {
            return _orderRepository.Delete(GetById(id));
        }

        public OrderItem Delete(OrderItem orderItem)
        {
            return _itemRepository.Delete(orderItem);
        }

        public ICollection<Order> GetAll()
        {
            return _orderRepository.GetAll().ToList();
        }

        public ICollection<OrderItem> GetAll(Order order)
        {
            return _itemRepository.GetAll().ToList();
        }

        public Order GetById(Guid id)
        {
            return _orderRepository.GetById(id);
        }

        public ShoppingCart GetByUserId(string userId)
        {
            return _shoppingCartRepository.GetAll()
                .FirstOrDefault(x => x.OrdersAppUserId.Equals(userId));
        }

        public Order Update(Order order)
        {
            return _orderRepository.Update(order);
        }

        public OrderItem Update(OrderItem orderItem)
        {
            return _itemRepository.Update(orderItem);
        }
    }
}
