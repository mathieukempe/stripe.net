using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountUpdateOptions
    {
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("bank_account")]
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("legal_entity[type]")]
        public string LegalEntityType { get; set; }

        [JsonProperty("legal_entity[business_name]")]
        public string LegalEntityBusinessName { get; set; }

        [JsonProperty("legal_entity[address][line1]")]
        public string LegalEntityAddressLine1 { get; set; }

        [JsonProperty("legal_entity[address][line2]")]
        public string LegalEntityAddressLine2 { get; set; }

        [JsonProperty("legal_entity[address][city]")]
        public string LegalEntityAddressCity { get; set; }

        [JsonProperty("legal_entity[address][state]")]
        public string LegalEntityAddressState { get; set; }

        [JsonProperty("legal_entity[address][postal_code]")]
        public string LegalEntityAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[address][country]")]
        public string LegalEntityAddressCountry { get; set; }

        [JsonProperty("legal_entity[dob][day]")]
        public int? LegalEntityDobDay { get; set; }

        [JsonProperty("legal_entity[dob][month]")]
        public int? LegalEntityDobMonth { get; set; }

        [JsonProperty("legal_entity[dob][year]")]
        public int? LegalEntityDobYear { get; set; }

        [JsonProperty("legal_entity[first_name]")]
        public string LegalEntityFirstName { get; set; }

        [JsonProperty("legal_entity[last_name]")]
        public string LegalEntityLastName { get; set; }

        [JsonProperty("legal_entity[personal_address][line1]")]
        public string PersonalAddressLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address][line2]")]
        public string PersonalAddressLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address][city]")]
        public string PersonalAddressCity { get; set; }

        [JsonProperty("legal_entity[personal_address][state]")]
        public string PersonalAddressState { get; set; }

        [JsonProperty("legal_entity[personal_address][postal_code]")]
        public string PersonalAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address][country]")]
        public string PersonalAddressCountry { get; set; }

        [JsonProperty("legal_entity[verification][document]")]
        public string LegalEntityVerificationDocument { get; set; }

        [JsonProperty("legal_entity[ssn_last_4]")]
        public int? SSN4 { get; set; }

        [JsonProperty("legal_entity[personal_id_number]")]
        public string LegalEntityPersonalIdNumber { get; set; }

        [JsonProperty("decline_charge_on[cvc_failure]")]
        public bool DeclineChargeOnCvcFailure { get; set; }

        [JsonProperty("decline_charge_on[avs_failure]")]
        public bool DeclineChargeOnAvcFailure { get; set; }
    }
}
