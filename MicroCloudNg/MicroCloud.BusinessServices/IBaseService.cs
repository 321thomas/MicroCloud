using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCloud.BusinessServices
{
    public interface IBaseService<TModel, TViewModel>
    {
        TViewModel GetById(int id);
        IList<TViewModel> GetAll();
        void Delete(int id);

        void CreateOrUpdate(TViewModel viewModel);
    }
}
