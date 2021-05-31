using System;
using System.Collections.Generic;
using Niteco.Cores.Interfaces;
using Niteco.Enums;

namespace Niteco.EventsControl.Events
{
    public class CarArriveEvent : IEvent
    {
        public string EventName => throw new NotImplementedException();
        public List<IEventListener> EventListeners => throw new NotImplementedException();
        public Intersection StartIntersection { get; private set; }

        public CarArriveEvent(Intersection startIntersection)
        {
            StartIntersection = startIntersection;
        }

        /// <summary>
        /// Add new event listener
        /// </summary>
        /// <param name="listener"></param>
        public void AddListener(IEventListener listener)
        {
            throw new NotImplementedException();
        }
    }
}
