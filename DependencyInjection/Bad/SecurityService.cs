using System;
using OpenClosed.Good;

namespace DependencyInjection.Bad
{
    public class SecurityService
    {
        private readonly ILogger _logger;

        public SecurityService()
        {
            _logger = new ConsoleLogger();
        }
        
        public void ChangeUsersPassword(Guid userId, string newPassword)
        {
            _logger.WriteLog($"user with id {userId} changed password with {newPassword}.");

            //TODO change password :)
        }
    }
}