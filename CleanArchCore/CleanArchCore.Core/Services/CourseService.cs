using CleanArchCore.Core.Interfaces;
using CleanArchCore.Core.ViewModels;
using CleanArchCore.DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchCore.Core.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository courseRepository;
        public CourseService(ICourseRepository courseRepository )
        {
            this.courseRepository = courseRepository;
        }
        public CourseViewModel GetCources()
        {
            return new CourseViewModel()
            {
                Courses = courseRepository.GetCourses()
            };
        }
    }
}
