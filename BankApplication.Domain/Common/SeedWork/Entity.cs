using System;
using System.Collections.Generic;

namespace BankApplication.Domain.Common.SeedWork
{
    public abstract class Entity
    {
        int? _requestedHashCode;
        public virtual Guid Id { get; protected set; }
        public bool Deleted { get;set; }
        
        // private List<IEvent> _domainEvents;
        // public IReadOnlyCollection<IEvent> DomainEvents => _domainEvents?.AsReadOnly();

        // public void AddDomainEvent(IEvent eventItem)
        // {
        //     _domainEvents = _domainEvents ?? new List<IEvent>();
        //     _domainEvents.Add(eventItem);
        // }

        // public void RemoveDomainEvent(IEvent eventItem)
        // {
        //     _domainEvents?.Remove(eventItem);
        // }

        // public void ClearDomainEvents()
        // {
        //     // _domainEvents?.Clear();
        // }

        public bool IsTransient()
        {
            return this.Id == default;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            var item = (Entity)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;
            else
                return item.Id == this.Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();

        }
        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null));
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
        protected Guid GetUniqueIdentifier()
        {
            // todo:need to use appropriate id provider
            var identityProvider = new UniqueIdentityProvider();
            return identityProvider.GenerateID();
        }
        
        // public void AddAuditLog(Guid accountantId)
        // {
        //     CreatedBy = accountantId;
        //     ModifiedBy = accountantId;
        //     ModifiedDate = DateTime.UtcNow;
        //     CreatedDate = DateTime.UtcNow;
        // }
        // public void UpdateAuditLog(Guid accountantId)
        // {
        //     ModifiedBy = accountantId;
        //     ModifiedDate = DateTime.UtcNow;
        // }
    }
}