using System;
using Autofac;
using OpenClosed.Good;

namespace DependencyInjection.Good
{
    class Startup
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AccountComponent>().As<IAccountComponent>();
            builder.RegisterType<SecurityService>().As<ISecurityService>();
            builder.RegisterType<ConsoleLogger>().As<ILogger>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IAccountComponent>();
                app.ChangePassword(Guid.NewGuid(), "new pass");
            }
        }
    }
}
