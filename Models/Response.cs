using HotChocolate;
using HotChocolate.Types;

namespace ECTM.Models.Entities
{
    public enum ResponseCode
    {
        Ok = 200,
        Updated = 202,
        Error = 500
    }



    public class Response
    {
        public int ResponseCode { get; set; }
        public string ResponseLabel { get; set; }
        public string ResponseMessage { get; set; }

        [GraphQLType(typeof(AnyType))]
        public object ResponseObject { get; set; }
    }
}