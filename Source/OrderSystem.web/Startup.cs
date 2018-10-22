using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace OrderSystem.web
{
    public class Startup 
    {

        public Startup(Iconfiguration configuration)
        {

            Configuration = configuration

        }

        public Iconfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOption>

        }









    }
}
