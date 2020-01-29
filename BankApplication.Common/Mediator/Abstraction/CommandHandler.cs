using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BankApplication.Common.Mediator.Abstraction
{
    public abstract class CommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : ICommand<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            return await HandleCommandAsync(request, cancellationToken);
        }

        public abstract Task<TResponse> HandleCommandAsync(TRequest request, CancellationToken cancellationToken);
    }
}
