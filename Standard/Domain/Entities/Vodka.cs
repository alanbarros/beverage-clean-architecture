using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Vodka : Beverage
    {
        public override int Level => 10;        

        public async override Task<Code> Turns(Developer dev)
        {
            var totalDelay = dev.GetDrinkDelay(this) * this.GetTotalDrinkLevel();

            return await Task.Run(async () =>
            {
                await Task.Delay(totalDelay);

                return new DeadCode(){Delayed = totalDelay};
            });
        }
    }
}