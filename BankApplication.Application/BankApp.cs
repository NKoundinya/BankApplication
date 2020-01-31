using System.Reflection;

namespace BankApplication.Application
{
    public static class BankApp
    {
        public static Assembly Assembly => typeof(BankApp).Assembly;
    }
}
