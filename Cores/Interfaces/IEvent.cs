using System;
using System.Collections.Generic;

namespace Niteco.Cores.Interfaces
{
    public interface IEvent
    {
        string EventName { get; }
        List<IEventListener> EventListeners{ get; }
    }
}