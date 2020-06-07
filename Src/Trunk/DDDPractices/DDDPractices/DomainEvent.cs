namespace DDDPractices
{
    public static class DomainEvent
    {
        
        public static IEventDispatcher Dispatcher { get; set; }

        public static void Raise<T>(T @event) where T : IDomainEvent
        {
            // C# 4.0 needs Framework 4.5
            Dispatcher.Dispatch((dynamic)@event);
        }
        
        
        
        
    }
}