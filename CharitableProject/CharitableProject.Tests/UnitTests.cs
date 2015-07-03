using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using CharitableProject.ServiceModel;
using CharitableProject.ServiceInterface;
using CharitableProject.ServiceModel.Types;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStack.Text;

namespace CharitableProject.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly ServiceStackHost appHost;

        public UnitTests()
        {
            appHost = new BasicAppHost(typeof(MyServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                    container.Register<IDbConnectionFactory>(new OrmLiteConnectionFactory("~/App_Data/db.sqlite",SqliteDialect.Provider));

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
        public void ImportCharityData()
        {
            var dbConnectionFactory = appHost.Container.Resolve<IDbConnectionFactory>();
            using (var db = dbConnectionFactory.OpenDbConnection())
            {
                db.DropAndCreateTable<Charity>();
            }
            using (var db = dbConnectionFactory.OpenDbConnection())
            {
                string currentPath = AppDomain.CurrentDomain.BaseDirectory;

                var filestream = File.OpenRead(Path.Combine(currentPath, ConfigurationManager.AppSettings["CharityPath"]));
                TextReader textreader = new StreamReader(filestream);
                var reader = new CsvHelper.CsvReader(textreader);

                var lol = reader.GetRecords<dynamic>();
                var charityJson = lol.ToJson();
                var data = JsonSerializer.DeserializeFromString<List<Charity>>(charityJson);

                db.InsertAll(data);
            }
        }

        [Test]
        public void ImportCharityMetadata()
        {
            var dbConnectionFactory = appHost.Container.Resolve<IDbConnectionFactory>();
            using (var db = dbConnectionFactory.OpenDbConnection())
            {
                db.DropAndCreateTable<CharityMetadata>();
            }
            using (var db = dbConnectionFactory.OpenDbConnection())
            {
                string currentPath = AppDomain.CurrentDomain.BaseDirectory;

                var filestream = File.OpenRead(Path.Combine(currentPath, ConfigurationManager.AppSettings["CharityMetadataPath"]));
                TextReader textreader = new StreamReader(filestream);
                var reader = new CsvHelper.CsvReader(textreader);

                var lol = reader.GetRecords<dynamic>();
                var charityJson = lol.ToJson();
                var data = JsonSerializer.DeserializeFromString<List<CharityMetadata>>(charityJson);

                db.InsertAll(data);
            }
        }
    }
}
