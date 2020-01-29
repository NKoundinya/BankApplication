using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Common.Enumerations
{
    public class Gender : Enumeration
    {
        public static Gender Female = new Gender(1, "Female");
        public static Gender Male = new Gender(2, "Man");
        public Gender() { }
        public Gender(int id, string displayName) : base(id, displayName) { }
    }
}