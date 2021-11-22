using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Write.Events
{
    public interface IEvent
    {
        long TimeStamp { get; set; }
        int AggregateId { get; set; }
        string Type { get; }
        int Version { get; set; }
    }
}
