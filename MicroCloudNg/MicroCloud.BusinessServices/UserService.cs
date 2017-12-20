using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MicroCloud.ViewModels;
using Microsoft.AspNetCore.Identity;
using MircoCloud.DAL.Models;
using MircoCloud.DAL.Repositories;

namespace MicroCloud.BusinessServices
{
    public class UserService : BaseService<User, UserVm>, IUserService, IUserStore<UserVm>
    {
        private IBaseRepository<User> repository;

        public UserService(IBaseRepository<User> repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public Task<IdentityResult> CreateAsync(UserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void CreateOrUpdateUser(UserVm user)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(UserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public Task<UserVm> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            return this.repository.GetAllAsync().Select(u => new UserVm
            {
                UserName = u.Username, // todo: doppelte property entfernen
                Username = u.Username,
                Id = u.Id,
                Password = u.Password
            }).FirstOrDefault(u => u.Username == userId);
        }

        public Task<UserVm> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public IList<UserVm> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(UserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public UserVm GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        //public Task<UserVm> GetUserByUsernameAsync(string username, CancellationToken cancellationToken)
        //{
        //    return this.repository.GetAllAsync()
        //        .Select(u=>new UserVm
        //        {
                     
        //        }
        //    throw new NotImplementedException();
        //}

        public Task<string> GetUserIdAsync(UserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(UserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(UserVm user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(UserVm user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(UserVm user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
