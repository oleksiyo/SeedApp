using System;
using SeedAPI.Models.Context;

namespace SeedAPI.Repositories
{
    public class BaseRepository<T> : IDisposable where T : class, new()
    {
        protected readonly IApplicationContext context;

        public BaseRepository(IApplicationContext context)
        {
            this.context = context;
        }

        public T Insert<T>(T domain)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T domain)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}
