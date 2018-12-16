using SeedAPI.Maps;
using SeedAPI.ViewModels;

namespace SeedAPI.Web.API.Configs
{
    public class DBInitializeConfig
    {
        private readonly IUserMaper userMap;

        public DBInitializeConfig(IUserMaper userMap)
        {
            this.userMap = userMap;
        }

        public void DataTest()
        {
            Users();
        }

        private void Users()
        {
            userMap.Create(new UserViewModel() { Password = "1", UserName = "Pablo" });
            userMap.Create(new UserViewModel() { Password = "2", UserName = "Diego" });
        }
    }
}