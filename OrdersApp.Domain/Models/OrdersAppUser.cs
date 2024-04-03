using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Domain.Models
{
    public class OrdersAppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
