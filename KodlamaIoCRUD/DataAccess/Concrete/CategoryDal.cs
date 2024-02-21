using KodlamaIoCRUD.DataAccess.Abstract;
using KodlamaIoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {

            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },
                new Category { Id = 3, Name = "Category 3" }
            };
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(int id)
        {
            Category category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _categories.Remove(category);
            }
            else
            {
                Console.WriteLine("Böyle bir kategori yok.");
            }
        }

        public List<Category> GetAll()
        {
            foreach (var category in _categories) 
            {
                Console.WriteLine($"{category.Name}");
            }
            return _categories;
        }

        public Category GetById(int id)
        {
            Category category = _categories.FirstOrDefault(c => c.Id == id);
            if(category != null)
            {
                Console.WriteLine("Kurs adı: " + category.Name);
            }
            else
            {
                Console.WriteLine("Böyle bir kategori yok.");
            }
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Category newCategory)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == newCategory.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = newCategory.Name;
            }
            else
            {
                Console.WriteLine("Böyle bir kategori yok.");
            }
        }
    }
}
