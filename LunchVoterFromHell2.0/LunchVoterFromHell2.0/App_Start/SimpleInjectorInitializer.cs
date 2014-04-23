[assembly: WebActivator.PostApplicationStartMethod(typeof(LunchVoterFromHell2.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace LunchVoterFromHell2.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Extensions;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Repository;
    using Repository.Repository.Contracts;
    using Repository.Repository;
    using DomainService.Contracts;
    using DomainService;
    
    public static class SimpleInjectorInitializer
    {
        private static Container container;

        public static Container Container
        {
            get
            {
                if (container == null)
                    container = new Container();

                return container;
            }
        }

        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.            
            InitializeContainer(Container);

            Container.RegisterMvcControllers(Assembly.GetExecutingAssembly());            
            Container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(Container));
        }
     
        private static void InitializeContainer(Container container)
        {
            container.Register<IDataContext, DataContext>();
            container.Register<IGroupRepository, GroupRepository>();
            container.Register<IGenericRepository, GenericRepository>();
            container.Register<IGroupBO, GroupBO>();
        }
    }
}