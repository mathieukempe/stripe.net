﻿using System.Collections.Generic;
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

            switch (extension)
            {
                case ".png":
                    return "image/png";
                case ".pdf":
                    return "application/pdf";
                case ".jpg":
                    return "image/jpeg";
                case ".jpeg":
                    return "image/jpeg";
            }

            return "";
        }

        public virtual StripeDocument UploadIdentityDocument(Stream file, string fileName)
        {
            var postData = new Dictionary<string, string>();
            postData.Add("purpose", "identity_document");

            var response = Requestor.PostMultipartFormString(Urls.Uploads, postData, file, fileName, MimeType(fileName), "file", ApiKey);

            return Mapper<StripeDocument>.MapFromJson(response);
        }

        public virtual StripeDocument UploadDisputeEvidence(Stream file, string fileName)
        {
            var postData = new Dictionary<string, string>();
            postData.Add("purpose", "dispute_evidence");

            var response = Requestor.PostMultipartFormString(Urls.Uploads, postData, file, fileName, MimeType(fileName), "file", ApiKey);

            return Mapper<StripeDocument>.MapFromJson(response);
        }
        
    }
}
