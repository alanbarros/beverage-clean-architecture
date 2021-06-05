using System;

namespace Domain.Entities
{
    public class Log : Entity
    {
        public Log(Guid id, string service, string message, DateTime dateTime, LogStatus status) : base(id)
        {
            this.Service = service;
            this.Message = message;
            DateTime = dateTime;
            Status = status;
        }

        public string Service { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public LogStatus Status { get; set; }

        public static Log ErrorLog(string service, string message) =>
            new Log(Guid.NewGuid(), service, message, DateTime.Now, LogStatus.Error);
        public static Log ProcessLog(string service, string message) =>
            new Log(Guid.NewGuid(), service, message, DateTime.Now, LogStatus.Process);
            
        public static Log SuccessLog(string service, string message) =>
            new Log(Guid.NewGuid(), service, message, DateTime.Now, LogStatus.Success);   

    }

    public enum LogStatus 
    {
        Process,
        Success,
        Error
    }
}