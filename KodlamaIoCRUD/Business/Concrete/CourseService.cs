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
    public class CourseService : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseService(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
