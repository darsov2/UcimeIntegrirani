using OrdersApp.Domain.Models;
using OrdersApp.Repository.Interface;
using OrdersApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
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
        private readonly IRepository<OrderItem> _orderItemRepository;
        private readonly IUserService _userService;

        public OrderService(IRepository<Order> orderRepository, 
            IRepository<OrderItem> itemRepository,
            IRepository<ShoppingCart> shoppingCartRepository,
            IRepository<OrderItem> orderItemRepository,
            IUserService userService)
        {
            _orderRepository = orderRepository;
            _itemRepository = itemRepository;
            _shoppingCartRepository = shoppingCartRepository;
            _orderItemRepository = orderItemRepository;
            _userService = userService;
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

        public void AddItemToShoppingCart(string userId, OrderItem orderItem)
        {
            ShoppingCart shoppingCart = _userService.GetUserById(userId).ShoppingCart;
            orderItem.Id = Guid.NewGuid();
            orderItem.ShoppingCart = shoppingCart;
            _orderItemRepository.Add(orderItem);
        }

        public List<OrderItem> GetShoppingCartItemsByUserId(string userId)
        {
            return _orderItemRepository.GetAllInclude("ShoppingCart", "ShoppingCart.User").Where(x => x.ShoppingCart != null && x.ShoppingCart.User.Id.Equals(userId)).ToList();
        }

        public void AddItemsToOrder(string userId,  ICollection<OrderItem> items)
        {
            Order order = new Order();
            order.Id = Guid.NewGuid();
            List<OrderItem> itemsToAdd = new List<OrderItem>();
            order.Items = items;
            _orderRepository.Add(order);
            items.ToList().ForEach(x =>
            {
                x.ShoppingCartId = null;
                x.ShoppingCart = null;
                _orderItemRepository.Update(x);
            });
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
