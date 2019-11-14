using CleanArchCore.Core.Interfaces;
using CleanArchCore.Core.Services;
using CleanArchCore.DomainLayer.Interfaces;
using CleanArchCore.Infra.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchCore.Infra.IoCProj
{
  public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
