using System;
using System.Collections.Generic;
using SeedAPI.Models.Models;
using SeedAPI.Repositories;

namespace SeedAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;

        public UserService(IRepository<User> userRepository)
        {
            repository = userRepository;
        }

        public void Create(User domain)
        {
            repository.Insert(domain);
        }

        public void Update(User domain)
        {
            repository.Update(domain);
        }

        public void Delete(Guid id)
        {
            repository.Delete(repository.Get(id));
        }

        public IEnumerable<User> GetAll()
        {
            return repository.GetAll();
        }
    }
}