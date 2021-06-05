using System.Linq;

namespace Application.UseCase.HireDevUseCase.Handlers
{
    public class HireDevHandler : Handler<Request>
    {
        public override void ProcessRequest(Request request)
        {
            request.AddProcessLog(GetType().FullName, "Hiring a developer");

            var dev = request.Developers.OrderBy(o => o.DrinkingRate).First();

            request.Output = new Boundaries.HireDev.HireDevOutput(dev);
            
            Sucessor?.ProcessRequest(request);
        }
    }
}