using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe.Entities
{
    public class StripeDeclineChargeOn
    {
        [JsonProperty("cvc_failure")]
        public bool CvcFailure { get; set; }

        [JsonProperty("avs_failure")]
        public bool AvsFailure { get; set; }
    }
}
