using Ninject;

namespace DDDPractices
{
    public class NinjectEventDispatcher: IEventDispatcher
    {
        private readonly IKernel _kernel;

        public NinjectEventDispatcher(IKernel kernel)
        {
            _kernel = kernel;
        }
        
        public void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent
        {
            
            foreach (var handler in _kernel.GetAll<IHandler<TEvent>>())
            {
                handler.Handle(eventToDispatch);
            }
        }
    }
}