using System.Reflection;

namespace BankApplication.Application
{
    public static class Bank
    {
        public static Assembly Assembly => typeof(Bank).Assembly;
    }
}
