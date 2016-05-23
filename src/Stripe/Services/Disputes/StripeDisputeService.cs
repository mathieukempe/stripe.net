﻿namespace Stripe
{
    public class StripeDisputeService : StripeService
    {
        public StripeDisputeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeDispute Update(string chargeId, StripeDisputeUpdateOptions evidence = null)
        {
            var url = string.Format("{0}/{1}/dispute",Urls.Charges, chargeId);
            
            var postData = this.ApplyAllParameters(evidence, "", false);

            //remove the ?
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostData(url, postData, ApiKey);

            return Mapper<StripeDispute>.MapFromJson(response);
        }

        public virtual StripeDispute Close(string chargeId)
        {
            var url = string.Format("{0}/{1}/dispute/close",Urls.Charges, chargeId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeDispute>.MapFromJson(response);
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