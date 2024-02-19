using KodlamaIoCRUD.Business.Concrete;
using KodlamaIoCRUD.DataAccess.Concrete;
using KodlamaIoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseService courseService = new CourseService(new CourseDal());

            // Tüm kursları listeleme
            Console.WriteLine("Tüm kurslar:");
            courseService.GetAll();

            //2 id ile kurs bilgisi okuma
            Console.WriteLine("Kurs 2 bilgileri");
            courseService.GetById(2);

            // Yeni bir kurs ekleme
            Course newCourse = new Course { Id = 4, Name = "Course 4", Description = "Description 4", CategoryId = 4, InstructorId = 4 };
            courseService.Add(newCourse);
            Console.WriteLine("Yeni kurs eklendi.");
            courseService.GetAll();

            // Kurs güncelleme
            Console.WriteLine("");
            Course courseToUpdate = courseService.GetById(1);
            courseService.Update(courseToUpdate);
            Console.WriteLine("Kurs güncellendi.");
            courseService.GetById(1);

            // Bir kursu silme
            int courseIdToDelete = 2;
            courseService.Delete(courseIdToDelete);
            Console.WriteLine($"ID'si {courseIdToDelete} olan kurs silindi.");
            courseService.GetAll();
        }
    }
}
