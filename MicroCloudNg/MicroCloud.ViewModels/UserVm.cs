using System;
using Microsoft.AspNetCore.Identity;

namespace MicroCloud.ViewModels
{
    public class UserVm : IdentityUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
