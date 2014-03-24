using Microsoft.Owin;
using Owin;
using LunchVoterFromHell2._0;
[assembly: OwinStartup(typeof(LunchVoterFromHell2._0.SignalRConfig))]

namespace LunchVoterFromHell2._0
{
    public class SignalRConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
} 