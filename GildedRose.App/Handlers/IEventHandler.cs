using GildedRose.App.Events;

namespace GildedRose.App.Handlers
{
    /// <summary>
    /// Defines a handler for an event
    /// </summary>
    /// <typeparam name="TEvent">The type of event being handled</typeparam>
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Item Handle(TEvent stock);
    }
}