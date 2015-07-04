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
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        public object Get(GetCharityWithMetadata request)
        {
            return new GetCharityWithMetadataResponse
            {
                Result = Db.Single<CharityMetadata>(x => x.ABN == request.ABN)
            };
        }
    }

    public class GetCharityWithMetadata : IReturn<GetCharityWithMetadataResponse>
    {
        public string ABN { get; set; }
    }

    public class GetCharityWithMetadataResponse
    {
        public CharityMetadata Result { get; set; }
    }
}
