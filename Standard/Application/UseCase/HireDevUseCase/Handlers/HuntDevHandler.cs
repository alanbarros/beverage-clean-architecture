using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Application.UseCase.HireDevUseCase.Handlers
{
    public class HuntDevHandler : Handler<Request>
    {
        public override void ProcessRequest(Request request)
        {
            request.AddProcessLog(GetType().FullName, "Hunting Devs");

            request.Developers.AddRange(GetDevs(10));
            
            Sucessor?.ProcessRequest(request);
        }

        private List<Developer> GetDevs(int qtd)
        {
            var listDevs = new List<Developer>();

            for (int i = 0; i < qtd; i++)
            {
                listDevs.Add(new Developer(Guid.NewGuid(), i, new Random().NextDouble()));                
            }

            return listDevs;
        }
    }
}