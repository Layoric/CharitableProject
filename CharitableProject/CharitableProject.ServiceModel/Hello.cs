using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharitableProject.ServiceModel.Types;
using ServiceStack;

namespace CharitableProject.ServiceModel
{
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }

    [Route("/charity/{ABN}")]
    public class GetCharityWithMetadata : IReturn<GetCharityWithMetadataResponse>
    {
        public string ABN { get; set; }
    }

    public class GetCharityWithMetadataResponse
    {
        public CharityMetadata Metadata { get; set; }
        public Charity Result { get; set; }
    }

    [Route("/find")]
    public class FindCharity : QueryBase<Charity>//, IJoin<Charity,CharityMetadata>
    {
        public string Name { get; set; }
    }
}
