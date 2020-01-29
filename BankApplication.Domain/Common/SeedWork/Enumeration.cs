using System;

namespace BankApplication.Domain.Common.SeedWork
{
    public abstract class Enumeration : IComparable
    {
        public string DisplayName { get; private set; }
        public int Id { get; private set; }
        protected Enumeration() { }
        protected Enumeration(int id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }
        public override string ToString() => DisplayName;
        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);
    }
}