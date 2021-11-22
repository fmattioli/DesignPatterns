using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Write.Events
{
    public interface IEventPublisher
    {
        void RegisterEventHandlers(IEventHandler eventHandler);
        void Publish<T>(T @evento) where T : IEvent;
    }
}
