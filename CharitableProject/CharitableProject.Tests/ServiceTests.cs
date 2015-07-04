using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharitableProject.ServiceInterface;
using CharitableProject.ServiceModel.Types;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStack.Testing;
using ServiceStack.Text;

namespace CharitableProject.Tests
{
    [TestFixture]
    public class ServiceTests
    {
        private readonly ServiceStackHost appHost;

        public ServiceTests()
        {
            appHost = new BasicAppHost(typeof(MyServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                    container.Register<IDbConnectionFactory>(new OrmLiteConnectionFactory("~/App_Data/db.sqlite".MapHostAbsolutePath(),
                        SqliteDialect.Provider));
                }
            }
            .Init();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            appHost.Dispose();
        }

        [Test]
        public void CanGetCharityById()
        {
            var service = appHost.Resolve<MyServices>();
            var result = (GetCharityWithMetadataResponse)service.Get(new GetCharityWithMetadata {ABN = "11029187646"});
            Assert.NotNull(result);
            Assert.AreEqual(result.Result.ABN, "11029187646");
        }
    }
}
