using Autofac;
using M2HW4.Configs;

namespace M2HW4
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var starter = container.Resolve<Starter>();
            starter.Run();
        }
    }
}