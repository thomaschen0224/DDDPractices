using System.CodeDom;
using Ninject;

namespace DDDPractices
{
    public static class InstanceFactory
    {

        private static readonly IKernel _kernel;

        static InstanceFactory()
        {
            _kernel = new StandardKernel();
            DomainEvent.Dispatcher = new NinjectEventDispatcher(_kernel);
            _kernel.Load<AppNinjectModule>();

        }

        public static T GetInstance<T>() where T : class
        {
            return _kernel.Get<T>();
        }

        public static void Initiate()
        {
            
        }
        
        
        
        
    }
}