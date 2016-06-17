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
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }
        
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("legal_entity[type]")]
        public string LegalEntityType { get; set; }

        [JsonProperty("legal_entity[gender]")]
        public string LegalEntityGender { get; set; }

        [JsonProperty("legal_entity[business_name]")]
        public string LegalEntityBusinessName { get; set; }

        [JsonProperty("legal_entity[business_name_kana]")]
        public string LegalEntityBusinessNameKana { get; set; }

        [JsonProperty("legal_entity[business_name_kanji]")]
        public string LegalEntityBusinessNameKanji { get; set; }

        [JsonProperty("legal_entity[address][line1]")]
        public string LegalEntityAddressLine1 { get; set; }

        [JsonProperty("legal_entity[address_kana][line1]")]
        public string LegalEntityAddressKanaLine1 { get; set; }

        [JsonProperty("legal_entity[address_kanji][line1]")]
        public string LegalEntityAddressKanjiLine1 { get; set; }

        [JsonProperty("legal_entity[address][line2]")]
        public string LegalEntityAddressLine2 { get; set; }

        [JsonProperty("legal_entity[address][line2_kana]")]
        public string LegalEntityAddressKanaLine2 { get; set; }

        [JsonProperty("legal_entity[address_kanji][line2]")]
        public string LegalEntityAddressKanjiLine2 { get; set; }

        [JsonProperty("legal_entity[address_kanji][town]")]
        public string LegalEntityAddressKanjiTown { get; set; }

        [JsonProperty("legal_entity[address_kana][town]")]
        public string LegalEntityAddressKanaTown { get; set; }

        [JsonProperty("legal_entity[address][city]")]
        public string LegalEntityAddressCity { get; set; }

        [JsonProperty("legal_entity[address_kana][city]")]
        public string LegalEntityAddressKanjiCity { get; set; }

        [JsonProperty("legal_entity[address_kanji][city]")]
        public string LegalEntityAddressKanaCity { get; set; }

        [JsonProperty("legal_entity[address][state]")]
        public string LegalEntityAddressState { get; set; }

        [JsonProperty("legal_entity[address_kanji][state]")]
        public string LegalEntityAddressKanjiState { get; set; }

        [JsonProperty("legal_entity[address_kana][state]")]
        public string LegalEntityAddressKanaState { get; set; }

        [JsonProperty("legal_entity[address][postal_code]")]
        public string LegalEntityAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[address_kana][postal_code]")]
        public string LegalEntityAddressKanaPostalCode { get; set; }

        [JsonProperty("legal_entity[address_kanji][postal_code]")]
        public string LegalEntityAddressKanjiPostalCode { get; set; }

        [JsonProperty("legal_entity[address][country]")]
        public string LegalEntityAddressCountry { get; set; }

        [JsonProperty("legal_entity[address_kana][country]")]
        public string LegalEntityAddressKanaCountry { get; set; }

        [JsonProperty("legal_entity[address_kanji][country]")]
        public string LegalEntityAddressKanjiCountry { get; set; }

        [JsonProperty("legal_entity[dob][day]")]
        public int? LegalEntityDobDay { get; set; }

        [JsonProperty("legal_entity[dob][month]")]
        public int? LegalEntityDobMonth { get; set; }

        [JsonProperty("legal_entity[dob][year]")]
        public int? LegalEntityDobYear { get; set; }

        [JsonProperty("legal_entity[maiden_name]")]
        public string LegalEntityMaidenName { get; set; }

        [JsonProperty("legal_entity[first_name]")]
        public string LegalEntityFirstName { get; set; }

        [JsonProperty("legal_entity[first_name_kana]")]
        public string LegalEntityFirstNameKana { get; set; }

        [JsonProperty("legal_entity[first_name_kanji]")]
        public string LegalEntityFirstNameKanji { get; set; }

        [JsonProperty("legal_entity[last_name]")]
        public string LegalEntityLastName { get; set; }
        
        [JsonProperty("legal_entity[last_name_kana]")]
        public string LegalEntityLastNameKana { get; set; }

        [JsonProperty("legal_entity[last_name_kanji]")]
        public string LegalEntityLastNameKanji { get; set; }

        [JsonProperty("legal_entity[ssn_last_4]")]
        public string SSN4 { get; set; }

        [JsonProperty("legal_entity[personal_id_number]")]
        public string LegalEntityPersonalIdNumber { get; set; }

        [JsonProperty("legal_entity[business_tax_id]")]
        public string LegalEntityBusinessTaxId { get; set; }

        [JsonProperty("legal_entity[business_vat_id]")]
        public string LegalEntityBusinessVatId { get; set; }

        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("transfer_schedule[delay_days]")]
        public int? TransferScheduleDelayDays { get; set; }

        [JsonProperty("transfer_schedule[interval]")]
        public string TransferScheduleInterval { get; set; }

        [JsonProperty("transfer_schedule[weekly_anchor]")]
        public string TransferScheduleWeeklyAnchor { get; set; }

        [JsonProperty("transfer_schedule[monthly_anchor]")]
        public string TransferScheduleMonthlyAnchor { get; set; }

        [JsonProperty("legal_entity[personal_address][line1]")]
        public string PersonalAddressLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][line1]")]
        public string PersonalAddressKanjiLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][line1]")]
        public string PersonalAddressKanaLine1 { get; set; }

        [JsonProperty("legal_entity[personal_address][line2]")]
        public string PersonalAddressLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][line2]")]
        public string PersonalAddressKanjiLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][line2]")]
        public string PersonalAddressKanaLine2 { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][town]")]
        public string PersonalAddressKanjiTown { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][town]")]
        public string PersonalAddressKanaTown { get; set; }

        [JsonProperty("legal_entity[personal_address][city]")]
        public string PersonalAddressCity { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][city]")]
        public string PersonalAddressKanjiCity { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][city]")]
        public string PersonalAddressKanaCity { get; set; }

        [JsonProperty("legal_entity[personal_address][state]")]
        public string PersonalAddressState { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][state]")]
        public string PersonalAddressKanjiState { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][state]")]
        public string PersonalAddressKanaState { get; set; }

        [JsonProperty("legal_entity[personal_address][postal_code]")]
        public string PersonalAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][postal_code]")]
        public string PersonalAddressKanjiPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][postal_code]")]
        public string PersonalAddressKanaPostalCode { get; set; }

        [JsonProperty("legal_entity[personal_address][country]")]
        public string PersonalAddressCountry { get; set; }

        [JsonProperty("legal_entity[personal_address_kana][country]")]
        public string PersonalAddressKanaCountry { get; set; }

        [JsonProperty("legal_entity[personal_address_kanji][country]")]
        public string PersonalAddressKanjiCountry { get; set; }

        [JsonProperty("tos_acceptance[date]")]
        public long TosAcceptanceDate { get; set; }

        [JsonProperty("tos_acceptance[ip]")]
        public string TosAcceptanceIp { get; set; }

        [JsonProperty("legal_entity[verification][document]")]
        public string LegalEntityVerificationDocument { get; set; }

        [JsonProperty("decline_charge_on[cvc_failure]")]
        public bool DeclineChargeOnCvcFailure { get; set; }

        [JsonProperty("decline_charge_on[avs_failure]")]
        public bool DeclineChargeOnAvcFailure { get; set; }

        [JsonProperty("legal_entity[additional_owners]")]
        public string Owners { get; set; }

        //Owner1
        [JsonProperty("legal_entity[additional_owners][0][dob][day]")]
        public int? OwnerOneLegalEntityDobDay { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][dob][month]")]
        public int? OwnerOneLegalEntityDobMonth { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][dob][year]")]
        public int? OwnerOneLegalEntityDobYear { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][first_name]")]
        public string OwnerOneLegalEntityFirstName { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][last_name]")]
        public string OwnerOneLegalEntityLastName { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][line1]")]
        public string OwnerOneAddressLine1 { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][line2]")]
        public string OwnerOneAddressLine2 { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][city]")]
        public string OwnerOneAddressCity { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][state]")]
        public string OwnerOneAddressState { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][postal_code]")]
        public string OwnerOneAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[additional_owners][0][address][country]")]
        public string OwnerOneAddressCountry { get; set; }

        //Owner 2
        [JsonProperty("legal_entity[additional_owners][1][dob][day]")]
        public int? OwnerTwoLegalEntityDobDay { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][dob][month]")]
        public int? OwnerTwoLegalEntityDobMonth { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][dob][year]")]
        public int? OwnerTwoLegalEntityDobYear { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][first_name]")]
        public string OwnerTwoLegalEntityFirstName { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][last_name]")]
        public string OwnerTwoLegalEntityLastName { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][line1]")]
        public string OwnerTwoAddressLine1 { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][line2]")]
        public string OwnerTwoAddressLine2 { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][city]")]
        public string OwnerTwoAddressCity { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][state]")]
        public string OwnerTwoAddressState { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][postal_code]")]
        public string OwnerTwoAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[additional_owners][1][address][country]")]
        public string OwnerTwoAddressCountry { get; set; }

        //Owner 3 
        [JsonProperty("legal_entity[additional_owners][2][dob][day]")]
        public int? OwnerThreeLegalEntityDobDay { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][dob][month]")]
        public int? OwnerThreeLegalEntityDobMonth { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][dob][year]")]
        public int? OwnerThreeLegalEntityDobYear { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][first_name]")]
        public string OwnerThreeLegalEntityFirstName { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][last_name]")]
        public string OwnerThreeLegalEntityLastName { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][line1]")]
        public string OwnerThreeAddressLine1 { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][line2]")]
        public string OwnerThreeAddressLine2 { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][city]")]
        public string OwnerThreeAddressCity { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][state]")]
        public string OwnerThreeAddressState { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][postal_code]")]
        public string OwnerThreeAddressPostalCode { get; set; }

        [JsonProperty("legal_entity[additional_owners][2][address][country]")]
        public string OwnerThreeAddressCountry { get; set; }

        
        
    }
}