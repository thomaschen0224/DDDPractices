using System;

namespace DDDPractices
{
    public class NameChangedEventHandler: IHandler<NameChangedEvent>
    {
        public void Handle(NameChangedEvent @event)
        {

            Console.WriteLine(
                $"Handle name changed event - First Name: {@event.FirstName} | Last Name: {@event.LastName}");
            

        }
    }
}