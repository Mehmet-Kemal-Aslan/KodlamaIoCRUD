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
                new Instructor { Id = 1, Name = "Mehmet", Surname = "Aslan" },
                new Instructor { Id = 2, Name = "Gizem", Surname = "Güneş" },
                new Instructor { Id = 3, Name = "Pelin", Surname = "Coşkun" }
            };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int id)
        {
            Instructor instructorToDelte = _instructors.FirstOrDefault(x => x.Id == id);
            if(instructorToDelte != null)
            {
                _instructors.Remove(instructorToDelte);
            }
            else
            {
                Console.WriteLine("Böyle bir eğitmen yok.");
            }
            
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            Instructor instructor = _instructors.FirstOrDefault(x => x.Id == id);
            if (instructor != null)
            {
                Console.WriteLine("Eğitmen adı: " + instructor.Name + "Soyadı" + instructor.Surname);
            }
            else
            {
                Console.WriteLine("Böyle bir eğitmen yok.");
            }
            return _instructors.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.FirstOrDefault(x => x.Id == instructor.Id);
            if (instructor != null)
            {
                instructorToUpdate.Name = instructor.Name;
                instructorToUpdate.Surname = instructor.Surname;
            }
            else
            {
                Console.WriteLine("Böyle bir eğitmen yok.");
            }
        }
    }
}
