namespace Application.Boundaries
{
    public interface IOutputPort<T>
    {
         void Standard(T outPut);
         void Error(string message);
    }
}