using Microsoft.Extensions.DependencyInjection;
using Moq;
using Application.UseCase.HireDevUseCase.Handlers;
using Application.Boundaries.HireDev;
using Application.Interfaces;
using System.Collections.Generic;
using Domain.Entities;
using Application.Boundaries;

namespace Standards
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<HireDevHandler>();
            services.AddScoped<HuntDevHandler>();
            services.AddScoped<IOutputPort<HireDevOutput>, Output>();
            services.AddSingleton<ILogRepository>(o => MockLog().Object);
            services.AddScoped<IHireDevUseCase, Application.UseCase.HireDevUseCase.UseCase>();
        }

        private Mock<ILogRepository> MockLog()
        {
            var mock = new Mock<ILogRepository>();

            mock.Setup(m => m.AddRange(It.IsAny<List<Log>>())).Verifiable();

            return mock;
        }
    }
}