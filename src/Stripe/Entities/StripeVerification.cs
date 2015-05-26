using System;
using Newtonsoft.Json;

namespace Stripe.Entities
{
    public class StripeVerification
    {
        [JsonProperty("contacted")]
        public bool Contacted { get; set; }

        [JsonProperty("fields_needed")]
        public string[] FieldsNeeded { get; set; }

        [JsonProperty("due_by")]
        public DateTime? DueBy { get; set; }
    }
}
