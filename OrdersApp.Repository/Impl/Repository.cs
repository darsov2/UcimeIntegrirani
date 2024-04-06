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
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> entites;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entites = _context.Set<T>();
        }

        public T Add(T entity)
        {
            entites.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Delete(T entity)
        {
            entites.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return entites.AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return entites.FirstOrDefault(x => x.Id == id);
        }

        public T Update(T entity)
        {
            entites.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> GetAllInclude(string include, string include1)
        {
            return entites.Include(include).Include(include1).AsEnumerable();
        }
    }
}
