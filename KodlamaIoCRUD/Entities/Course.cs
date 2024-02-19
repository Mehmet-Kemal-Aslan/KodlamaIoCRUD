using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.Entities
{
    public class Course : Baseentity
    {
        public string Description { get; set; }
        public Category Category { get; set; }
        public Instructor Instructor { get; set; }
    }
}
