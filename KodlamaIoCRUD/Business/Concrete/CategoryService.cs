using KodlamaIoCRUD.Business.Abstract;
using KodlamaIoCRUD.DataAccess.Abstract;
using KodlamaIoCRUD.DataAccess.Concrete;
using KodlamaIoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.Business.Concrete
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(IGenericDal<Category> genericDal) : base(genericDal)
        {
        }
    }
}
