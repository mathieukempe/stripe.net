using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Entities;

namespace Stripe
{
    public class StripeLegalEntity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_name_kana")]
        public string BusinessNameKana { get; set; }

        [JsonProperty("business_name_kanji")]
        public string BusinessNameKanji { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
        
        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("address_kana")]
        public StripeAddress AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public StripeAddress AddressKanji { get; set; }

        [JsonProperty("personal_address")]
        public StripeAddress PersonalAddress { get; set; }

        [JsonProperty("personal_address_kana")]
        public StripeAddress PersonalAddressKana { get; set; }

        [JsonProperty("personal_address_kanji")]
        public StripeAddress PersonalAddressKanji { get; set; }
        
        [JsonProperty("business_tax_id")]
        public string BusinessTaxId { get; set; }

        [JsonProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        [JsonProperty("dob")]
        public StripeBirthDay BirthDay { get; set; }

        [JsonProperty("ssn_last_4")]
        public string SSN4 { get; set; }

        [JsonProperty("verification")]
        public StripeLegalEntityVerification Verification { get; set; }

        [JsonProperty("additional_owners")]
        public IList<AdditionalOwner> AdditionalOwners { get; set; }
    }

    public class AdditionalOwner
    {
        [JsonProperty("dob")]
        public StripeBirthDay Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address")]
        public StripeAddress Address { get; set; }        
    }
}
