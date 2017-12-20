using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MicroCloud.BusinessServices;
using MicroCloud.ViewModels;

namespace MicroCloud.Mocks.BusinessServices
{
    public class UserServiceMock : IUserService
    {
        public void CreateOrUpdateUser(UserVm user)
        {

        }

        public void DeleteUserById(int id)
        {

        }

        public Task<UserVm> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UserVm { Username = userId, UserName = userId });
        }

        public IList<UserVm> GetAllUsers()
        {
            return new List<UserVm>
            {
                new UserVm{ Email = "my@email.com", Id=1, Password ="pwd", Username="myUsername"}
            };
        }

        public UserVm GetUserById(int id)
        {
            return new UserVm { Email = "my@email.com", Id = id, Password = "pwd", Username = "myUsername" };
        }
    }
}
