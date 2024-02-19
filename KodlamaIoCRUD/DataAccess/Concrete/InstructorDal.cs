using KodlamaIoCRUD.DataAccess.Abstract;
using KodlamaIoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {

            _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, Name = "Nur", Surname = "Vural" },
                new Instructor { Id = 2, Name = "Tuba", Surname = "Günaçgün" },
                new Instructor { Id = 3, Name = "Emine", Surname = "Yılmaz" }
            };
        }
        public void Add(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
