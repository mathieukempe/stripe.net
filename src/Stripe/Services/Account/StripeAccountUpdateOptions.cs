﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Entities;

namespace Stripe
{
    public class StripeAccountUpdateOptions
    {
        [JsonProperty("bank_account")]
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("legal_entity[type]")]
        public string LegalEntityType { get; set; }

        [JsonProperty("legal_entity[business_name]")]
        public string LegalEntityBusinessName { get; set; }

        [JsonProperty("transfer_schedule[delay_days]")]
        public int? TransferScheduleDelayDays { get; set; }

        [JsonProperty("transfer_schedule[interval]")]
        public string TransferScheduleInterval { get; set; }

        [JsonProperty("transfer_schedule[weekly_anchor]")]
        public string TransferScheduleWeeklyAnchor { get; set; }

        [JsonProperty("transfer_schedule[monthly_anchor]")]
        public string TransferScheduleMonthlyAnchor { get; set; }

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
        public string SSN4 { get; set; }

        [JsonProperty("legal_entity[personal_id_number]")]
        public string LegalEntityPersonalIdNumber { get; set; }

        [JsonProperty("decline_charge_on[cvc_failure]")]
        public bool? DeclineChargeOnCvcFailure { get; set; }

        [JsonProperty("decline_charge_on[avs_failure]")]
        public bool? DeclineChargeOnAvcFailure { get; set; }

        [JsonProperty("legal_entity[business_tax_id]")]
        public string LegalEntityBusinessTaxId { get; set; }

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

        [JsonProperty("legal_entity[additional_owners][0][verification][document]")]
        public string OwnerOneVerificationDocument { get; set; }

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

        [JsonProperty("legal_entity[additional_owners][1][verification][document]")]
        public string OwnerTwoVerificationDocument { get; set; }
        
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

        [JsonProperty("legal_entity[additional_owners][2][verification][document]")]
        public string OwnerThreeVerificationDocument { get; set; }
        
    }


}
