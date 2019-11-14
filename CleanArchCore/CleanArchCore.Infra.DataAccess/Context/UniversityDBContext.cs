using CleanArchCore.DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchCore.Infra.DataAccess.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {

        }

        public  DbSet<CourseEntity> CourseDBContext { set; get; }
    }
}
