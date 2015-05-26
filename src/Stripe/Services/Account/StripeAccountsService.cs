namespace Stripe
{
    public class StripeAccountsService : StripeService
    {
        public StripeAccountsService(string apiKey = null)
            : base(apiKey)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                ApiKey = StripeConfiguration.GetApiKey();
            }
        }

        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Accounts, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Get(string id)
        {
            var url = string.Format(Urls.SpecificAccount, id);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Update(string id, StripeAccountUpdateOptions updateOptions)
        {
            var url = this.ApplyAllParameters(updateOptions, string.Format(Urls.SpecificAccount, id), false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
    }
}
