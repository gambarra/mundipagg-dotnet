using System;

namespace Mundipagg.Models.Response
{
    public class GetTokenResponse
    {
        public GetCardTokenResponse Card { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ExpiresAt { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }
    }
}