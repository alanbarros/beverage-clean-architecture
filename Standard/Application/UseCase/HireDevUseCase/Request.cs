using System.Collections.Generic;
using Domain.Entities;

namespace Application.UseCase.HireDevUseCase
{
    public class Request : BaseRequest
    {
        public Boundaries.HireDev.HireDevOutput Output { get; set; }

        public List<Developer> Developers {get; set; } = new List<Developer>();
    }
}