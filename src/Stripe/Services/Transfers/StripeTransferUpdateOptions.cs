using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferUpdateOptions
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
