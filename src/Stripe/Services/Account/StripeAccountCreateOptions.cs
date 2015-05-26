using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountCreateOptions
    {
        [JsonProperty("managed")]
        public string Managed { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

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

        [JsonProperty("legal_entity[ssn_last_4]")]
        public int? SSN4 { get; set; }

        [JsonProperty("legal_entity[business_tax_id]")]
        public int? LegalEntityBusinessTaxId { get; set; }

        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("transfer_schedule[delay_days]")]
        public int? TransferScheduleDelayDays { get; set; }

        [JsonProperty("transfer_schedule[interval]")]
        public string TransferScheduleInterval { get; set; }

        [JsonProperty("tos_acceptance[date]")]
        public long TosAcceptanceDate { get; set; }

        [JsonProperty("tos_acceptance[ip]")]
        public string TosAcceptanceIp { get; set; }
    }
}