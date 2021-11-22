using CQRS.Infrastructure.Read.Persistence.People;

namespace CQRS.Application.Read.People
{
    public interface IPersonService : IApplicationService<Person>
    {
        Person Find(int id);
        IQueryable<Person> GetByName(string nome);
        IQueryable<Person> GetAll();    
        void Insert(Person person);
        void Update(Person person);
        void Delete(int Id);
    }
}
