namespace DDDPractices
{
    public class NameChangedEvent: IDomainEvent
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        

        public NameChangedEvent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;


        }



    }
}