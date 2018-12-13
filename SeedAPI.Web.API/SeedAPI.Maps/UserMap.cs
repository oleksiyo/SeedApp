using System.Collections.Generic;
using SeedAPI.Models.Models;
using SeedAPI.ViewModels;

namespace SeedAPI.Maps
{
    public class UserMap : IUserMap
    {
        readonly IUserService userService;

        public UserMap(IUserService service)
        {
            userService = service;
        }

        public UserViewModel Create(UserViewModel viewModel)
        {
            var user = ViewModelToDomain(viewModel);
            return DomainToViewModel(userService.Create(user));
        }

        public bool Update(UserViewModel viewModel)
        {
            var user = ViewModelToDomain(viewModel);
            return userService.Update(user);
        }

        public bool Delete(int id)
        {
            return userService.Delete(id);
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