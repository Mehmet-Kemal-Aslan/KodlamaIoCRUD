﻿using KodlamaIoCRUD.Business.Abstract;
using KodlamaIoCRUD.DataAccess.Abstract;
using KodlamaIoCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCRUD.Business.Concrete
{
    public class CourseService : GenericService<Course>, ICourseService
    {
        public CourseService(IGenericDal<Course> genericDal) : base(genericDal)
        {
        }
    }
}
