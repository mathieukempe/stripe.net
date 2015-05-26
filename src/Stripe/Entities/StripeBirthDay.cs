using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe.Entities
{
    using Newtonsoft.Json;

    public class StripeBirthDay
    {
        [JsonProperty("day")]
        public int? Day { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }
    }
}
