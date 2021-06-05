namespace Application.Interfaces.Services
{
    public interface IDrinkMachine<T> where T : Domain.Entities.Beverage
    {
         T GetSome();
    }
}