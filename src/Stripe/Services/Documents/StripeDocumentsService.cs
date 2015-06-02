using System.Collections.Generic;
using System.IO;

namespace Stripe
{
    public class StripeDocumentsService : StripeService
    {
        public StripeDocumentsService(string apiKey = null)
            : base(apiKey)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                ApiKey = StripeConfiguration.GetApiKey();
            }
        }

        private string MimeType(string path)
        {
            var extension = Path.GetExtension(path);

            if (extension == "png") return "image/png";
            if (extension == "pdf") return "application/pdf";
            if (extension == "jpg") return "image/jpeg";
            if (extension == "jpeg") return "image/jpeg";

            return "";
        }

        public virtual StripeDocument UploadIdentityDocument(FileStream file)
        {
            var postData = new Dictionary<string, string>();
            postData.Add("purpose", "identity_document");

            var response = Requestor.PostMultipartFormString(Urls.Uploads, postData, file, MimeType(file.Name), "file", ApiKey);

            return Mapper<StripeDocument>.MapFromJson(response);
        }

        public virtual StripeDocument UploadDisputeEvidence(FileStream file)
        {
            var postData = new Dictionary<string, string>();
            postData.Add("purpose", "dispute_evidence");

            var response = Requestor.PostMultipartFormString(Urls.Uploads, postData, file, MimeType(file.Name), "file", ApiKey);

            return Mapper<StripeDocument>.MapFromJson(response);
        }
        
    }
}
