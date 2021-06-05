using System.Linq;
using Application.Boundaries;
using Application.Boundaries.HireDev;
using Application.Interfaces;

namespace Application.UseCase.HireDevUseCase
{
    public class UseCase : BaseUseCase<Request, Boundaries.HireDev.HireDevOutput>, IHireDevUseCase
    {
        private readonly Handler<Request> initialHandler;
        private readonly ILogRepository _logRepository;

        public UseCase(Handlers.HuntDevHandler huntDevHandler,
            Handlers.HireDevHandler hireDevHandler,
            ILogRepository logRepository,
            IOutputPort<Boundaries.HireDev.HireDevOutput> outputPort)
            : base(outputPort)
        {
            _logRepository = logRepository;
            huntDevHandler.SetSucessor(hireDevHandler);

            initialHandler = huntDevHandler;
        }

        public override void Execute(Request request)
        {
            try
            {
                initialHandler.ProcessRequest(request);

                BuildOutput(request);
            }
            catch (System.Exception ex)
            {
                request.AddErrorLog(GetType().FullName, ex.Message + ex.StackTrace);
                OutputPort.Error(ex.Message);
            }
            finally
            {
                _logRepository.AddRange(request.Logs);
            }
        }

        private void BuildOutput(Request request)
        {
            var errors = request.Logs.Where(e => e.Status == Domain.Entities.LogStatus.Error);

            if (errors.Any())
            {
                OutputPort.Error(errors.Last().Message);
                return;
            }

            OutputPort.Standard(request.Output);
        }
    }
}