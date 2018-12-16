using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SeedAPI.Models.Context;
using SeedAPI.Models.EntityBase;
using SeedAPI.Models.Models;

namespace SeedAPI.Repositories
{
    public class BaseRepository
    {
        protected readonly IApplicationContext context;

        public BaseRepository(IApplicationContext context)
        {
            this.context = context;
        }

        public User Insert(User entity)
        {
            var user = context.UsersDB.Add(entity);
            context.SaveChanges();
            return user.Entity;
        }

        public void Update<T>(T domain)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }

    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }


    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(Guid id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
