using Microsoft.Owin;
using Owin;
using LunchVoterFromHell2;
[assembly: OwinStartup(typeof(LunchVoterFromHell2.SignalRConfig))]

namespace LunchVoterFromHell2
{
    public class SignalRConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
} 