using System.Collections.Generic;
using SeedAPI.Models.Models;

public interface IUserService
{
    User Create(User domain);

    bool Update(User domain);

    bool Delete(int id);

    List<User> GetAll();
}