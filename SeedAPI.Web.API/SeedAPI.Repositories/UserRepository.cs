using System;
using System.Collections.Generic;
using System.Linq;
using SeedAPI.Models.Context;
using SeedAPI.Models.Models;

namespace SeedAPI.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IApplicationContext context)
            : base(context)
        {
        }

        public User Save(User domain)
        {
            try
            {
                var us = Insert(domain);
                return us;
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }
        }

        public bool Update(User domain)
        {
            try
            {
                //domain.Updated = DateTime.Now;
                Update<User>(domain);
                return true;
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var user = context.UsersDB.Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }

                //Delete(user.Id);
                return true;
            }

            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return context.UsersDB.OrderBy(x => x.Name).ToList();
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }
        }
    }
}