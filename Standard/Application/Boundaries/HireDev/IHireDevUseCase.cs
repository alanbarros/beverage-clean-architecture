namespace Application.Boundaries.HireDev
{
    public interface IHireDevUseCase
    {
        void Execute(UseCase.HireDevUseCase.Request request);
    }
}