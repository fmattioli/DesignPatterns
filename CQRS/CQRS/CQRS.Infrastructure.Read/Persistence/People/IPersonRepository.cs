using CQRS.Infrastructure.Read.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure.Read.Persistence.People
{
    public interface IPersonRepository : IRepository<Person>
    {

    }
}
