using System;
using OpenClosed.Good;

namespace DependencyInjection.Good
{
    public interface ISecurityService
    {
        void ChangeUsersPassword(Guid userId, string newPassword);
    }

    public class SecurityService : ISecurityService
    {
        private readonly ILogger _logger;

        public SecurityService(ILogger logger)
        {
            _logger = logger;
        }
        
        public void ChangeUsersPassword(Guid userId, string newPassword)
        {
            _logger.WriteLog($"user with id {userId} changed password with {newPassword}.");

            //TODO change password :)
        }
    }
}