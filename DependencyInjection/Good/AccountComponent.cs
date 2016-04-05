using System;

namespace DependencyInjection.Good
{
    public interface IAccountComponent
    {
        void ChangePassword(Guid userId, string newPassword);
    }

    public class AccountComponent : IAccountComponent
    {
        private readonly ISecurityService _securityService;

        public AccountComponent(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        public void ChangePassword(Guid userId, string newPassword)
        {
            _securityService.ChangeUsersPassword(userId, newPassword);
        }
    }
}