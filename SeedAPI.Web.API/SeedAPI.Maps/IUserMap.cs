using System.Collections.Generic;
using SeedAPI.Models.Models;
using SeedAPI.ViewModels;

namespace SeedAPI.Maps
{
    public interface IUserMap
    {
        UserViewModel Create(UserViewModel viewModel);

        bool Update(UserViewModel viewModel);

        bool Delete(int id);

        List<UserViewModel> GetAll();

        UserViewModel DomainToViewModel(User user);

        List<UserViewModel> DomainToViewModel(List<User> users);

        User ViewModelToDomain(UserViewModel userViewModel);
    }
}