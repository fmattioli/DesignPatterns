using CQRS.Infrastructure.Read.Persistence.Interfaces;
using CQRS.Infrastructure.Read.Persistence.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure.Read.Persistence
{
    public class Contexto : IContexto
    {
        public IPersonRepository People { get; set; }
        public Contexto(IPersonRepository personRepository)
        {
            this.People = personRepository; 
        }

        
    }
}
