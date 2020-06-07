using System;
using System.Collections.Generic;

namespace DDDPractices
{
    public abstract class AggregateRoot: Entity
    {
        
        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;
        
        protected virtual void AddDomainEvent(IDomainEvent newEvent)
        {
            _domainEvents.Add(newEvent);
        }

        public virtual void ClearEvents()
        {
            _domainEvents.Clear();
        }


        protected virtual void RaiseAllEvents()
        {
            foreach (var domainEvent in _domainEvents)
            {
                DomainEvent.Raise(domainEvent);
            }
            
            ClearEvents();
            
        }




    }
}