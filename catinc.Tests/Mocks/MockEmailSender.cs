using catinc.Repositories;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.MemberSystem;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using catinc.Services;
using System.Threading.Tasks;

namespace catinc.Tests.Mocks
{
    public class MockEmailSender : IEmailSender
    {
        /// <summary>
        /// Mock Logger for unit tests
        /// </summary>
        public MockEmailSender() 
            : base()
        {}

        public Task SendEmailAsync(string email, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}