using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Common.Enumerations
{
    public class Country : Enumeration
    {
        public static Country IND = new Country(1, "IND");
        public static Country USA = new Country(2, "USA");
        public static Country UK = new Country(3, "UK");
        public static Country NL = new Country(4, "NL");
        public static Country AFG = new Country(5, "AFG");
        public Country() { }
        public Country(int id, string displayName) : base(id, displayName) { }
    }
}