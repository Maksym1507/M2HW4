using Autofac;
using M2HW4.Interfaces;
using M2HW4.Services;

namespace M2HW4.Configs
{
    public class Config
    {
        public Config()
        {
            Builder = new ContainerBuilder();
        }

        private ContainerBuilder Builder { get; }

        public IContainer RegisterTypes()
        {
            Builder.RegisterType<NotificationService>().As<INotificationService>();
            Builder.RegisterType<Starter>();
            return Builder.Build();
        }
    }
}
