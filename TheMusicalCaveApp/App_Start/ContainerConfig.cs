using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web.Mvc;
using TheMusicalCaveApp.Persistance.Repositories.Implementations;
using TheMusicalCaveApp.Persistance.Repositories.Interfaces;
using TheMusicalCaveApp.Services.Implementations;
using TheMusicalCaveApp.Services.Interfaces;

namespace TheMusicalCaveApp.App_Start
{
    public class ContainerConfig
    {
        public static void RegisterIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AlbumService>().As<IAlbumService>().SingleInstance();
            builder.RegisterType<AlbumRespository>().As<IAlbumRepository>().SingleInstance();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            
            var container=builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}