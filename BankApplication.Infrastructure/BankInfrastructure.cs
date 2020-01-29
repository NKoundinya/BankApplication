using System.Reflection;

namespace BankApplication.Infrastructure
{
    public static class BankInfrastructure
    {
        public static Assembly Assembly => typeof(BankInfrastructure).Assembly;
    }
}
