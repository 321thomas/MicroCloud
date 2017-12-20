using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MircoCloud.DAL;
using System.Linq;
using MircoCloud.DAL.Models;

namespace MircoCloud.DAL.Repositories
{
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseEntity
    {
        private readonly AppDbContext dbContext;
        public BaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateOrUpdate(TModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TModel> GetAll()
        {
            return this.dbContext.Set<TModel>().AsEnumerable().ToList();
        }

        public IAsyncEnumerable<TModel> GetAllAsync()
        {
            return this.dbContext.Set<TModel>().ToAsyncEnumerable();
        }

        public TModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
