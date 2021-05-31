using System;
namespace Niteco.Cores.Interfaces
{
    public interface IEventListener
    {
        string EventName { get; }
        void Execute();
    }
}
