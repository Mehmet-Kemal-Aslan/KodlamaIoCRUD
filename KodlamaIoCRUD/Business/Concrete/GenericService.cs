using KodlamaIoCRUD.Business.Abstract;
using KodlamaIoCRUD.DataAccess.Abstract;
using KodlamaIoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.Business.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericService(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }
        public void Add(T entity)
        {
            _genericDal.Add(entity);
        }

        public void Delete(int id)
        {
            _genericDal.Delete(id);
        }

        public List<T> GetAll()
        {
            return _genericDal.GetAll();
        }

        public T GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void Update(T entity)
        {
            _genericDal.Update(entity);
        }
    }
}
