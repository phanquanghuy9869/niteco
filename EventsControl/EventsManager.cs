using System;
using System.Collections.Generic;
using Niteco.Cores.Interfaces;

namespace Niteco.Events
{
    /// <summary>
    /// Management centralization of events and event handlers
    /// </summary>
    public class EventsManager
    {
        private List<IEvent> Events;
        private List<IEventListener> EventListeners;

        public EventsManager()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initialize the default mapping between events and eventListeners
        /// </summary>
        public void RegisterEvents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Subcrise a listener to a event
        /// </summary>
        /// <param name="listener">Event handler</param>
        /// <param name="ev">Event</param>
        public void Register(IEventListener listener, IEvent ev) {
            throw new NotImplementedException();
        }
    }
}
