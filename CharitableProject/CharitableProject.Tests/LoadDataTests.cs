using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Text;

namespace CharitableProject.Tests
{
    [TestFixture]
    public class LoadDataTests
    {
        [Test]
        public void ImportData()
        {
            var filestream = File.OpenRead(Path.Combine(ConfigurationManager.AppSettings["DataPath"], "20150617_DataDotGov.csv"));
            TextReader textreader = new StreamReader(filestream);
            var reader = new CsvHelper.CsvReader(textreader);

            var lol = reader.GetRecords<dynamic>();

            Console.WriteLine(lol.Take(1).ToJson());
        }
    }
}


public class Rootobject
{
    public Class1[] Property1 { get; set; }
}




