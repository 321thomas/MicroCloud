using System;
using System.Collections.Generic;
using System.Text;
using MircoCloud.DAL;
using MircoCloud.DAL.Repositories;

namespace MicroCloud.BusinessServices
{
    public class BaseService<TModel, TViewModel> : IBaseService<TModel, TViewModel>
    {
        private IBaseRepository<TModel> repository;
        public BaseService(IBaseRepository<TModel> repository)
        {
            this.repository = repository;
        }
        public void CreateOrUpdate(TViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
