using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.Entities
{
    public class Category : Baseentity
    {
        public ICollection<Course> Courses { get; set;}
    }
}
