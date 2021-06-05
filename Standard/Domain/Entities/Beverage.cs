using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Entities
{
    public abstract class Beverage
    {
        public int Qtd { get; set; }
        public abstract int Level { get; }
        public int GetTotalDrinkLevel() => Qtd * Level;
        public abstract Task<Code> Turns(Developer dev);
    }
}