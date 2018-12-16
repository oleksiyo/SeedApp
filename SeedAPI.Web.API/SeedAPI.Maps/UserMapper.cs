using System;
using System.Collections.Generic;
using SeedAPI.Models.Models;
using SeedAPI.ViewModels;

namespace SeedAPI.Maps
{
    public class UserMapper : IUserMapper
    {
        readonly IUserService userService;

        public UserMapper(IUserService service)
        {
            userService = service;
        }

        public UserViewModel Create(UserViewModel viewModel)
        {
            var user = ViewModelToDomain(viewModel);
            userService.Create(user);
            return null;
        }

        public bool Update(UserViewModel viewModel)
        {
            var user = ViewModelToDomain(viewModel);
            userService.Update(user);
            return true;
        }

        IEnumerable<UserViewModel> IUserMapper.GetAll()
        {
            return GetAll();
        }

        public bool Delete(Guid id)
        {
            userService.Delete(id);
            return true;
        }

        public List<UserViewModel> GetAll()
        {
            return DomainToViewModel(userService.GetAll());
        }

        public UserViewModel DomainToViewModel(User user)
        {
            return new UserViewModel { UserName = user.Name };
        }

        public List<UserViewModel> DomainToViewModel(List<User> users)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> DomainToViewModel(IEnumerable<User> users)
        {
            var model = new List<UserViewModel>();
            foreach (var of in users)
            {
                model.Add(DomainToViewModel(of));
            }
            return model;
        }

        public User ViewModelToDomain(UserViewModel userViewModel)
        {
            return new User { Name = userViewModel.UserName };
        }
    }
}