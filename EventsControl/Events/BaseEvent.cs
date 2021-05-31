using System;
using System.Collections.Generic;
using Niteco.Cores.Interfaces;

namespace Niteco.EventsControl.Events
{
    public class BaseEvent : IEvent
    {
        public string EventName { get; private set; }
        public List<IEventListener> EventListeners { get; private set; }

        public BaseEvent()
        {
            EventName = this.GetType().Name;
            EventListeners = new List<IEventListener>();
        }

        public void AddListener(IEventListener listener)
        {
            this.EventListeners.Add(listener);
        }
    }
}
