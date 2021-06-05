using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ILogRepository
    {
         void AddRange(List<Log> logs);
    }
}