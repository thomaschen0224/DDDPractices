namespace DDDPractices
{
    public class PhoneChangedEvent: IDomainEvent
    {

        public string Phone { get; private set; }

        public PhoneChangedEvent(string phone)
        {
            Phone = phone;
        }
        
        
    }
}