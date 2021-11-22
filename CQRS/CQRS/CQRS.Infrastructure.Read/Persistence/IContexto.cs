using CQRS.Infrastructure.Read.Persistence.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure.Read.Persistence.Interfaces
{
    public interface IContexto
    {
        IPersonRepository People { get; set; }
    }
}
