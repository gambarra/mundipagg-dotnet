using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetGatewayResponseResponse
    {
        public string Code { get; set; }

        public List<GetGatewayErrorResponse> Errors { get; set; }
    }
}