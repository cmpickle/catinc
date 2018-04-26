using catinc.Repositories;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.MemberSystem;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.Extensions.Logging;
using System;
using catinc.Controllers;

namespace catinc.Tests.Mocks
{
    public class MockLogger<Controller> : ILogger<Controller>
    {
        /// <summary>
        /// Mock Logger for unit tests
        /// </summary>
        public MockLogger() 
            : base()
        {}

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            throw new NotImplementedException();
        }
    }
}