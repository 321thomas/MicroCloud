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
            this.dbContext.Add(model);
        }

        public void Delete(int id)
        {
            TModel model = this.GetById(id);
            if (model != null)
            {
                this.dbContext.Remove(model);
            }
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
            return this.dbContext.Set<TModel>().Find(id);
        }

        public Task<TModel> GetByIdAsync(int id)
        {
            return this.dbContext.Set<TModel>().FindAsync(id);
        }
        public Task SaveChangesAsync()
        {
            return this.dbContext.SaveChangesAsync();
        }
    }
}
