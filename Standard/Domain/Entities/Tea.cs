using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tea : Beverage
    {
        public override int Level => 2;        

        public async override Task<Code> Turns(Developer dev)
        {
            var totalDelay = dev.GetDrinkDelay(this) * this.GetTotalDrinkLevel();

            return await Task.Run(async () =>
            {
                await Task.Delay(totalDelay);

                return new SweetCode(){Delayed = totalDelay};
            });
        }
    }
}