using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDeveloper
    {
        Task<Code> Drink<T>(T beverage) where T : Beverage;
    }
}