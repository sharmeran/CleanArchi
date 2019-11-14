using CleanArchCore.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchCore.DomainLayer.Interfaces
{
   public interface ICourseRepository
    {
        IEnumerable<CourseEntity> GetCourses();
    }
}
