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
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}
