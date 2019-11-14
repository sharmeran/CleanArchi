using CleanArchCore.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchCore.Core.ViewModels
{
  public class CourseViewModel 
    {
        public IEnumerable<CourseEntity> Courses { set; get; }
    }
}
