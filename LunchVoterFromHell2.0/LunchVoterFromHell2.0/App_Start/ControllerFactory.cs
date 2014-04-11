using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LunchVoterFromHell2.App_Start
{
    public class ControllerFactory : DefaultControllerFactory
    {
        private Container container;

        public ControllerFactory()
        {
            this.container = SimpleInjectorInitializer.Container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (controllerType == null) ? null : (IController)this.container.GetInstance(controllerType);
        }
    }
}