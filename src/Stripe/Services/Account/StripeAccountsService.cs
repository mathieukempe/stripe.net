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
            var postData = this.ApplyAllParameters(createOptions, "", false);

            //remove the ?
            postData = RemoveQuestionMark(postData);
            
            var response = Requestor.PostData(Urls.Accounts, postData, ApiKey);

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
            var postData = this.ApplyAllParameters(updateOptions, "" ,false);

            //remove the ?
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostData(string.Format(Urls.SpecificAccount, id), postData, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        private static string RemoveQuestionMark(string source)
        {
            int index = source.IndexOf("?");
            string clean = (index < 0)
                ? source
                : source.Remove(index, "?".Length);

            return clean;
        }
    }
}
