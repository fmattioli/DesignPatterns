using CQRS.Infrastructure.Read.Persistence.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Read.People
{
    public class PessoaService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PessoaService(IPersonRepository _personRepository)
        {
            this._personRepository = _personRepository;
        }
        public void Delete(int Id)
        {
            _personRepository.Delete(Id);
        }

        public Person Find(int id)
        {
            return _personRepository.Find(id);
        }

        public IQueryable<Person> GetAll()
        {
            return _personRepository.Get();
        }

        public IQueryable<Person> GetByName(string nome)
        {
            return _personRepository.Get(p => p.Nome.ToUpper().Contains(nome.ToUpper()));
        }

        public void Insert(Person person)
        {
            _personRepository.Insert(person);
        }

        public void Update(Person person)
        {
            _personRepository.Update(person);
        }
    }
}
