using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Funq;
using ServiceStack;
using ServiceStack.Razor;
using CharitableProject.ServiceInterface;
using CharitableProject.ServiceModel.Types;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace CharitableProject
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("CharitableProject", typeof(MyServices).Assembly)
        {

        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        /// <param name="container"></param>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());

            this.Plugins.Add(new RazorFormat());
            this.Plugins.Add(new AutoQueryFeature { MaxLimit = 500 });

            container.Register<IDbConnectionFactory>(new OrmLiteConnectionFactory("~/App_Data/db.sqlite".MapHostAbsolutePath(),
                SqliteDialect.Provider));

            var dbFactory = container.Resolve<IDbConnectionFactory>();
            //Assume data is loaded/sqlite file is present
            using (var db = dbFactory.OpenDbConnection())
            {
                if (!db.TableExists<Charity>())
                {
                    throw new ApplicationException();
                }
            }
        }
    }
}