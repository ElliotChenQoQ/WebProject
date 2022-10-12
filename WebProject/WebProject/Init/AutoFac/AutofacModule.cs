using Autofac;
using Autofac.Extras.DynamicProxy;
using System.Linq;
using System.Reflection;

namespace WebProject.Init.AutoFac
{
    public class AutofacModule : Autofac.Module
    {
        private static readonly string[] registerInstances = { "Facade", "Service", "Dao", "MWare" };

        protected override void Load(ContainerBuilder builder)
        {
            Assembly coreAssembly = Assembly.GetExecutingAssembly();

            // === 註冊物件 ===
            foreach (string registerInstance in registerInstances)
            {
                builder.RegisterAssemblyTypes(coreAssembly)
                       .Where(t => t.Name.EndsWith(registerInstance))
                       .AsImplementedInterfaces()
                       .SingleInstance()
                       .PropertiesAutowired()
                       .EnableInterfaceInterceptors();
            }

            // === 註冊Controller，需變更Startup設定 ===
            builder.RegisterAssemblyTypes(coreAssembly)
                   .Where(t => t.Name.EndsWith("Controller"))
                   .AsSelf()
                   .PropertiesAutowired();
        }
    }
}