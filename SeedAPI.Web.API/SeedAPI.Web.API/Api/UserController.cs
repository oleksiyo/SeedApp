using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeedAPI.Maps;
using SeedAPI.ViewModels;

namespace SeedAPI.Web.API.Api
{
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : Controller
    {
        readonly IUserMap userMap;

        public UserController(IUserMap map)
        {
            userMap = map;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return userMap.GetAll();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string user)
        {

        }

        [HttpPut("{id}")]

        public void Put(int id, [FromBody]string user)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}