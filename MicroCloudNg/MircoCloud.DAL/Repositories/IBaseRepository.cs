using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MircoCloud.DAL.Repositories
{
    public interface IBaseRepository<TModel>
    {
        TModel GetById(int id);

        Task<TModel> GetByIdAsync(int id);

        IList<TModel> GetAll();

        IAsyncEnumerable<TModel> GetAllAsync();

        void Delete(int id);

        void CreateOrUpdate(TModel model);
    }
}
