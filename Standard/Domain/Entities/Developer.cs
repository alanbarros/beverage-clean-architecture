using System;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Developer : Entity, Interfaces.IDeveloper
    {
        public Developer(Guid id, int num, double drinkingRate) : base(id)
        {
            Num = num;
            DrinkingRate = drinkingRate;
        }
        public int Num { get; set; }
        public double DrinkingRate { get; set; }

        public async Task<Code> Drink<T>(T beverage) where T : Beverage
            => await beverage.Turns(this);

        public int GetDrinkDelay(Beverage beverage)
            => ((int)Math.Floor(DrinkingRate * 10));

    }
}