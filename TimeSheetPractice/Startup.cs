using Owin;
using Microsoft.Owin;
using System;

[assembly: OwinStartupAttribute(typeof(TimeSheetPractice.Startup))]
namespace TimeSheetPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            //app.MapSignalR();

        }

      
    }
}