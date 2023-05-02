using Autofac;
using Autofac.Extras.CommonServiceLocator;
using ClineControlApp.Utilities.Contracts;
using ClineControlApp.Utilities.Services;
using ClineControlApp.ViewModels;
using ClineControlApp.Views;
using CommonServiceLocator;
using Xamarin.Forms;

namespace ClineControlApp
{
    public abstract class AppContainer
    {           
        public void Setup()
        {
            var containerBuilder = new ContainerBuilder();

            RegisterServices(containerBuilder);

            var container = containerBuilder.Build();

            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));

            container.BeginLifetimeScope();
        }

        protected virtual void RegisterServices(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<App>().SingleInstance();
            
            containerBuilder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();

            containerBuilder.RegisterType<MainView>().Named<Page>(ViewNames.MainView).As<MainView>().InstancePerDependency();
            containerBuilder.RegisterType<LoginScreenPage>().Named<Page>(ViewNames.LoginScreenPage).As<LoginScreenPage>().InstancePerDependency();
            containerBuilder.RegisterType<OverViewPage>().Named<Page>(ViewNames.OverViewPage).As<OverViewPage>().InstancePerDependency();
            containerBuilder.RegisterType<DeviceDetailPage>().Named<Page>(ViewNames.DeviceDetailPage).As<DeviceDetailPage>().InstancePerDependency();
            containerBuilder.RegisterType<TestPage>().Named<Page>(ViewNames.TestPage).As<TestPage>().InstancePerDependency();

            containerBuilder.RegisterType<BaseMainViewModel>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<LoginPageViewModel>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<OverViewPageViewModel>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<TestViewModel>().InstancePerLifetimeScope();
        }
    }
}
