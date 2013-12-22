using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIWithNinject.Infrastructure;
using DIWithNinject.Services;
using Ninject;

namespace DIWithNinject.Core
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IMessageService>().To<MessageService>();
        }

        private IKernel kernel;

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}