using System.Collections.Generic;
using SeedAPI.Models.Models;

namespace SeedAPI.Repositories
{
    public interface IUserRepository
    {
        User Save(User domain);

        bool Update(User domain);

        bool Delete(int id);

        List<User> GetAll();
    }
}