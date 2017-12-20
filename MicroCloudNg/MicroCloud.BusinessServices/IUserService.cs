using System;
using System.Collections.Generic;
using MicroCloud.ViewModels;
using System.Threading.Tasks;
using System.Threading;

namespace MicroCloud.BusinessServices
{
    public interface IUserService
    {
        UserVm GetUserById(int id);

        Task<UserVm> FindByIdAsync(string userId, CancellationToken cancellationToken);
        //Task<UserVm> GetUserByUsernameAsync(string username, CancellationToken cancellationToken);

        IList<UserVm> GetAllUsers();

        void DeleteUserById(int id);
        void CreateOrUpdateUser(UserVm user);
    }
}
