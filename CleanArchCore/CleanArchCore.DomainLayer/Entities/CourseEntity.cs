using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchCore.DomainLayer.Entities
{
   public class CourseEntity
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string ImageURL { set; get; }

    }
}
