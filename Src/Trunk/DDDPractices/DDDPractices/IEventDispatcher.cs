namespace DDDPractices
{
    public interface IEventDispatcher
    {
        
        void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent; 
        
        
    }
}