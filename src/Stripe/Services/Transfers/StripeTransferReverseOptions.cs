﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferReverseOptions
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
