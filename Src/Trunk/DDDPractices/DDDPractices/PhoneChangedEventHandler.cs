using System;

namespace DDDPractices
{
    public class PhoneChangedEventHandler: IHandler<PhoneChangedEvent>
    {
        public void Handle(PhoneChangedEvent @event)
        {
            
            Console.WriteLine($"Handle phone changed event - Phone: {@event.Phone}");
            
            
        }
    }
}