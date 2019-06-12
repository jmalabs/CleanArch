using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext context;

        public CourseRepository(UniversityDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }
    }
}
