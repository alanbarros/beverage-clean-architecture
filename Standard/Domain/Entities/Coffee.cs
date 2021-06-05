using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Coffee : Beverage
    {
        public override int Level => 5;        

        public async override Task<Code> Turns(Developer dev)
        {
            var totalDelay = dev.GetDrinkDelay(this) * this.GetTotalDrinkLevel();

            return await Task.Run(async () =>
            {
                await Task.Delay(totalDelay);

                return new HotCode(){Delayed = totalDelay};
            });
        }
    }
}