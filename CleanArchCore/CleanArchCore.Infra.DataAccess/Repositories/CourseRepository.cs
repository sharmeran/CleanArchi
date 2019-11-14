using CleanArchCore.DomainLayer.Entities;
using CleanArchCore.DomainLayer.Interfaces;
using CleanArchCore.Infra.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchCore.Infra.DataAccess.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext dbContext;
        public CourseRepository(UniversityDBContext ctx)
        {
            dbContext = ctx;
        }
        public IEnumerable<CourseEntity> GetCourses()
        {
            return dbContext.CourseDBContext;
        }
    }
}