using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class UpdateAddressRequest
    {
        public string Complement { get; set; }

        public string Line2 { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Number { get; set; }
    }
}