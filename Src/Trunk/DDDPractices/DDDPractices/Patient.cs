using System;

namespace DDDPractices
{
    public class Patient : AggregateRoot
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Phone { get; protected set; }


        public Patient(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }


        public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;


            var nameChangedEvent = new NameChangedEvent(firstName, lastName);
            AddDomainEvent(nameChangedEvent);


        }

        public void ChangePhone(string phone)
        {
            Phone = phone;

            var phoneChangedEvent = new PhoneChangedEvent(phone);
            AddDomainEvent(phoneChangedEvent);
        }

        public void SaveChanges()
        {
            RaiseAllEvents();

            Console.WriteLine($"Save into database...");
        }
    }
}