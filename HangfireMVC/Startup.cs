using Hangfire;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(HangfireMVC.Startup))]

namespace HangfireMVC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            //連線sql server  執行前先在新增一個Hangfire 資料庫,  其他的資料表會自己產生
            GlobalConfiguration.Configuration.UseSqlServerStorage("Data Source=.;Initial Catalog=Hangfire;Persist Security Info=True;User ID=sa;Password=!QAZ@wsx;Integrated Security=SSPI;");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}