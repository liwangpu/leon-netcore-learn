﻿using MediatR;
using System.Collections.Generic;

namespace Base.Domain.Common
{
    public abstract class Entity
    {
        public string Id { get; protected set; }
        private List<INotification> _domainEvents;
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();


        public bool IsTransient()
        {
            return !string.IsNullOrWhiteSpace(Id);
        }

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }
    }
}
