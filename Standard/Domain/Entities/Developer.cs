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
            => await this.Drink(beverage);

        private int GetDrinkDelay(Beverage beverage)
            => ((int)Math.Floor(DrinkingRate)) * beverage.GetTotalDrinkLevel();

        protected async virtual Task<Code> Drink(Beer beer)
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(GetDrinkDelay(beer));

                return new FreshCode();
            });
        }

        protected async virtual Task<Code> Drink(Coffee coffee)
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(GetDrinkDelay(coffee));

                return new HotCode();
            });
        }

        protected async virtual Task<Code> Drink(Tea tea)
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(GetDrinkDelay(tea));

                return new SweetCode();
            });
        }

        protected async virtual Task<Code> Drink(Vodka vodka)
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(GetDrinkDelay(vodka));

                return new DeadCode();
            });
        }
    }
}