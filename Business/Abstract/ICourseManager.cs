using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICourseManager
    {
       void AddCourse(Course course);
        void DeleteCourse(Course course);

        void UpdateCourse(Course course);

        List<Course> GetAll();
    }
}
