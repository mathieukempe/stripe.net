﻿using Newtonsoft.Json;
 
namespace Stripe
{
    public class StripeInvoiceLineListOptions : StripeListOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}