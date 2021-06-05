using System.Collections.Generic;
using Domain.Entities;

namespace Application.UseCase
{
    public abstract class BaseRequest
    {        
        public List<Log> Logs { get; set; } = new List<Log>();

        public void AddErrorLog(string service, string message) =>
            Logs.Add(Log.ErrorLog(service, message));
        public void AddProcessLog(string service, string message) =>
            Logs.Add(Log.ProcessLog(service, message));
        public void AddSuccessLog(string service, string message) =>
            Logs.Add(Log.SuccessLog(service, message));
    }
}