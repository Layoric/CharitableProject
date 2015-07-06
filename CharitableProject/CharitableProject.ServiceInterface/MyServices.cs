using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using CharitableProject.ServiceModel;
using CharitableProject.ServiceModel.Types;
using ServiceStack.OrmLite;

namespace CharitableProject.ServiceInterface
{
    public class MyServices : Service
    {
        public IAutoQuery AutoQuery { get; set; }

        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        public object Get(GetCharityWithMetadata request)
        {
            return new GetCharityWithMetadataResponse
            {
                Metadata = Db.Single<CharityMetadata>(x => x.ABN == request.ABN),
                Result = Db.Single<Charity>(x => x.ABN == request.ABN)
            };
        }

        //Auto query
        public object Get(FindCharity request)
        {
            var q = AutoQuery.CreateQuery(request, Request.GetRequestParams());
            var result =  AutoQuery.Execute(request, q);
            result.Results = result.Results.Select(x => new CharityMetadata
            {
                Charity_Name = x.Charity_Name,
                ABN = x.ABN
            }).ToList();
            return result;
        }
    }

    public class SearchResultCharityMetadata
    {
        public string ABN { get; set; }
        public string Charity_Name { get; set; }
    }
}
