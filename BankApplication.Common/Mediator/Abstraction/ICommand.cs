using MediatR;

namespace BankApplication.Common.Mediator.Abstraction
{
    public interface ICommand<out T> : IRequest<T>
    {
    }
}
