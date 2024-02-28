using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IInstructorManager
    {
        void AddInstructor(Instructor instructor);
        void RemoveInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
        List<Instructor> GetAllInstructors();
    }
}
