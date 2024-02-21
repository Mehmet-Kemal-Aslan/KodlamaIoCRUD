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
            CategoryService categoryService = new CategoryService(new CategoryDal());
            InstructorService instructorService = new InstructorService(new InstructorDal());


            Console.WriteLine("Tüm kurslar:");
            courseService.GetAll();


            Console.WriteLine("Kurs 2 bilgileri");
            courseService.GetById(2);

   
            Course newCourse = new Course { Id = 4, Name = "Course 4", Description = "Description 4", CategoryId = 4, InstructorId = 4 };
            courseService.Add(newCourse);
            Console.WriteLine("Yeni kurs eklendi.");
            courseService.GetAll();


            Console.WriteLine("");
            Course courseToUpdate = courseService.GetById(1);
            courseService.Update(courseToUpdate);
            Console.WriteLine("Kurs güncellendi.");
            courseService.GetById(1);


            int courseIdToDelete = 2;
            courseService.Delete(courseIdToDelete);
            Console.WriteLine($"ID'si {courseIdToDelete} olan kurs silindi.");
            courseService.GetAll();


           
            Console.WriteLine("\n\nTüm kategoriler:");
            categoryService.GetAll();
  
            Console.WriteLine("\nKategori ekleniyor");
            Category newCategory = new Category { Id = 4, Name = "Category 4" };
            categoryService.Add(newCategory);
            Console.WriteLine("Yeni kategori eklendi.");
            categoryService.GetAll();

            Console.WriteLine("Kategor 1 güncelleniyor");
            Category categoryToUpdate = categoryService.GetById(1);
            categoryToUpdate.Name = "Updated Category";
            categoryService.Update(categoryToUpdate);
            Console.WriteLine("Kategori güncellendi.");
            categoryService.GetById(1);

            Console.WriteLine("Kategori 2 siliniyor.");
            int categoryIdToDelete = 2;
            categoryService.Delete(categoryIdToDelete);
            Console.WriteLine($"ID'si {categoryIdToDelete} olan kategori silindi.");
            categoryService.GetAll();



            Console.WriteLine("\n\nTüm eğitmenler:");
            instructorService.GetAll();
       
            Console.WriteLine("\nEğitmen ekleniyor");
            Instructor newInstructor = new Instructor { Id = 4, Name = "Mehmet" , Surname = "Aslan"};
            instructorService.Add(newInstructor);
            Console.WriteLine("Yeni eğitmen eklendi.");
            instructorService.GetAll();

            Console.WriteLine("Eğitmen 1 güncelleniyor");
            Instructor instructorToUpdate = instructorService.GetById(1);
            instructorToUpdate.Name = "Updated Category";
            instructorService.Update(instructorToUpdate);
            Console.WriteLine("Eğitmen güncellendi.");
            instructorService.GetById(1);
     
            Console.WriteLine("Eğitmen 2 siliniyor.");
            int instructorIdToDelete = 2;
            categoryService.Delete(instructorIdToDelete);
            Console.WriteLine($"ID'si {instructorIdToDelete} olan eğitmen silindi.");
            instructorService.GetAll();

        }
    }
}
