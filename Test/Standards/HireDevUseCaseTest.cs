using Application.Boundaries;
using Application.Boundaries.HireDev;
using Application.UseCase.HireDevUseCase.Handlers;
using Xunit;

namespace Standards
{
    public class HireDevUseCaseTest
    {
        private readonly Output _output;
        private readonly IHireDevUseCase _useCase;

        public HireDevUseCaseTest(
            IOutputPort<HireDevOutput> output,
            IHireDevUseCase useCase
            )
        {
            _useCase = useCase;
            _output = (Output)output;
        }

        [Fact]
        public void ShouldHireADev()
        {
            var request = new Application.UseCase.HireDevUseCase.Request();
            _useCase.Execute(request);

            Assert.NotNull(_output.Result);
        }
    }
}