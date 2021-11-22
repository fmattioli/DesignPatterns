using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Write.Events
{
    public class Event : IEvent
    {
        public long TimeStamp { get; set; }
        public int AggregateId { get; set; }

        public string Type {get { return this.GetType().Name; } }

        public int Version { get; set; }
    }
}
