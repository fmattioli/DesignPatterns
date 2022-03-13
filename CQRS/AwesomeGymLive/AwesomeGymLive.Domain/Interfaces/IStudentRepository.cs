using AwesomeGymLive.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGymLive.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> GetAll();
    }
}
