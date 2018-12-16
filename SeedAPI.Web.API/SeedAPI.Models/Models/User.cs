using System;
using Microsoft.AspNetCore.Identity;

namespace SeedAPI.Models.Models
{
    public class User : EntityBase.EntityBase
    {
        public string Name { get; set; }
    }
}