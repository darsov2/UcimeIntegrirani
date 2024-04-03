using OrdersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Service.Interface
{
    public interface IOrderService
    {
        ICollection<Order> GetAll();
        Order GetById(Guid id);
        Order Add(Order order);
        Order Update(Order order);
        Order Delete(Guid id);
        ICollection<OrderItem> GetAll(Order order);
        OrderItem Add(OrderItem orderItem);
        OrderItem Update(OrderItem orderItem);
        OrderItem Delete(OrderItem orderItem);
        ShoppingCart GetByUserId(string userId);

    }
}
