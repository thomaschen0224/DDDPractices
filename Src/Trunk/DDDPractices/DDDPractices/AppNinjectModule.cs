using DDDPractices.Services;
using Ninject.Modules;

namespace DDDPractices
{
    public class AppNinjectModule: NinjectModule
    {
        public override void Load()
        {
            // Repositories
            Bind<IMessageRepository>().To<MessageRepository>();
            
            // Services
            Bind<IDoSomethingService>().To<DoSomethingService>();
            
            // Handlers
            Bind<IHandler<NameChangedEvent>>().To<NameChangedEventHandler>();
            Bind<IHandler<PhoneChangedEvent>>().To<PhoneChangedEventHandler>();



        }
    }
}