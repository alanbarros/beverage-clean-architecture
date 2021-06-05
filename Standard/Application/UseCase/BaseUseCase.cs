using Application.Boundaries;

namespace Application.UseCase
{
    public abstract class BaseUseCase<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : class
    {
        protected BaseUseCase(IOutputPort<TResponse> outputPort)
        {
            OutputPort = outputPort;
        }

        protected IOutputPort<TResponse> OutputPort { get; }

        
        public abstract void Execute(TRequest request);
    }
}