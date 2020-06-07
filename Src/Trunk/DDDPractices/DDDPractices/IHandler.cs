namespace DDDPractices
{
    public interface IHandler<T> where T: IDomainEvent
    {

        void Handle(T @event);

    }
}