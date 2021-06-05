namespace Application.UseCase
{
    public abstract class Handler<T> where T : class
    {
        public Handler<T> Sucessor {get; private set;}

        public Handler<T> SetSucessor(Handler<T> handler) =>
            Sucessor = handler;

        public abstract void ProcessRequest(T request);
    }
}