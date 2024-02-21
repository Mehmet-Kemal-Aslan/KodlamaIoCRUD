using KodlamaIoCRUD.DataAccess.Abstract;
using KodlamaIoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {

            _courses = new List<Course>
            {
                new Course { Id = 1, Name = "Course 1", Description = "Description 1", CategoryId = 1, InstructorId = 1 },
                new Course { Id = 2, Name = "Course 2", Description = "Description 2", CategoryId = 2, InstructorId = 2 },
                new Course { Id = 3, Name = "Course 3", Description = "Description 3", CategoryId = 3, InstructorId = 3 }
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int id)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.Id == id);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
            else
            {
                Console.WriteLine("Böyle bir kurs yok.");
            }
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine( "Kurs adı: " + course.Name + "Tanım" + course.Description );
            }
            return _courses;
        }

        public Course GetById(int id)
        {
            Course course = _courses.FirstOrDefault(c => c.Id == id);
            Console.WriteLine("Kurs adı: " + course.Name + "Tanım" + course.Description);
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course newCourse)
        {
            Course course = _courses.FirstOrDefault(c => c.Id == newCourse.Id);
            if(course != null)
            {
                course.Name = newCourse.Name;
                course.Description = newCourse.Description;
                course.CategoryId = newCourse.CategoryId;
                course.InstructorId = newCourse.InstructorId;
            }
            else
            {
                Console.WriteLine("Böyle bir kurs yok.");
            }
        }
    }
}
