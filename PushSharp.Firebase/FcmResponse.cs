using System.Collections.Generic;
using Newtonsoft.Json;

namespace PushSharp.Firebase
{
    public class FcmResponse
    {
        public FcmResponse()
        {
            MulticastId = -1;
            NumberOfSuccesses = 0;
            NumberOfFailures = 0;
            NumberOfCanonicalIds = 0;
            OriginalNotification = null;
            Results = new List<FcmMessageResult>();
            ResponseCode = FcmResponseCode.Ok;
        }

        [JsonProperty("multicast_id")]
        public long MulticastId { get; set; }

        [JsonProperty("success")]
        public long NumberOfSuccesses { get; set; }

        [JsonProperty("failure")]
        public long NumberOfFailures { get; set; }

        [JsonProperty("canonical_ids")]
        public long NumberOfCanonicalIds { get; set; }

        [JsonIgnore]
        public FcmNotification OriginalNotification { get; set; }

        [JsonProperty("results")]
        public List<FcmMessageResult> Results { get; set; }

        [JsonIgnore]
        public FcmResponseCode ResponseCode { get; set; }
    }
}
