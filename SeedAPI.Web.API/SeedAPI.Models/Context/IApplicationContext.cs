using Microsoft.EntityFrameworkCore;
using SeedAPI.Models.Models;

namespace SeedAPI.Models.Context
{
    public interface IApplicationContext
    {
        DbSet<User> UsersDB { get; set; }

        void SaveChanges();

        DbSet<User> Set<T>() where T : class;

        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }
}