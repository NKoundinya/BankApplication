using MediatR;

namespace BankApplication.Common.Mediator.Abstraction
{
    public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> 
        where TRequest : ICommand<TResponse>
    {
    }
}
