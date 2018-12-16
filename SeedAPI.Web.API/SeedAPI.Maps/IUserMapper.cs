using System;
using System.Collections.Generic;
using SeedAPI.Models.Models;
using SeedAPI.ViewModels;

namespace SeedAPI.Maps
{
    public interface IUserMapper
    {
        UserViewModel Create(UserViewModel viewModel);

        bool Update(UserViewModel viewModel);

        bool Delete(Guid id);

        IEnumerable<UserViewModel> GetAll();

        UserViewModel DomainToViewModel(User user);

        List<UserViewModel> DomainToViewModel(List<User> users);

        User ViewModelToDomain(UserViewModel userViewModel);
    }
}