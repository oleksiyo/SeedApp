using System;
using System.Collections.Generic;
using SeedAPI.Models.Models;

public interface IUserService
{
    void Create(User domain);

    void Update(User domain);

    void Delete(Guid id);

    IEnumerable<User> GetAll();
}