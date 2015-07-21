namespace Stripe
{
    public class StripeDisputeService : StripeService
    {
        public StripeDisputeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeDispute Update(string chargeId, StripeDisputeEvidence evidence = null)
        {
            var url = string.Format("{0}/dispute", chargeId);

            url = this.ApplyAllParameters(evidence, url, true);
            
            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeDispute>.MapFromJson(response);
        }

        public virtual StripeDispute Close(string chargeId)
        {
            var url = string.Format("{0}/dispute/close", chargeId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeDispute>.MapFromJson(response);
        }
    }
}