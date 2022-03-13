using AwesomeGymLive.Domain.Entities;
using AwesomeGymLive.Domain.Interfaces;

namespace AwesomeGymLive.Domain.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student("Felipe Mattioli dos Santos", DateTime.Now)
            };
        }
    }
}
