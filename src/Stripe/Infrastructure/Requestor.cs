using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Stripe
{
    internal static class Requestor
    {
        public static string GetString(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "GET", apiKey);

            return ExecuteWebRequest(wr);
        }
       
        public static string PostString(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "POST", apiKey);

            return ExecuteWebRequest(wr);
        }

        public static string PostStringBearer(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "POST", apiKey, true);

            return ExecuteWebRequest(wr);
        }

        public static string Delete(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "DELETE", apiKey);

            return ExecuteWebRequest(wr);
        }

        internal static WebRequest GetWebRequest(string url, string method, string apiKey = null, bool useBearer = false)
        {
            apiKey = apiKey ?? StripeConfiguration.GetApiKey();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = method;

            if(!useBearer)
                request.Headers.Add("Authorization", GetAuthorizationHeaderValue(apiKey));
            else
                request.Headers.Add("Authorization", GetAuthorizationHeaderValueBearer(apiKey));

            request.Headers.Add("Stripe-Version", StripeConfiguration.ApiVersion);

            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Stripe.net (https://github.com/jaymedavis/stripe.net)";

            return request;
        }

        private static string GetAuthorizationHeaderValue(string apiKey)
        {
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:", apiKey)));
            return string.Format("Basic {0}", token);
        }

        private static string GetAuthorizationHeaderValueBearer(string apiKey)
        {
            return string.Format("Bearer {0}", apiKey);
        }

        private static string ExecuteWebRequest(WebRequest webRequest)
        {
            try
            {
                using (var response = webRequest.GetResponse())
                {
                    return ReadStream(response.GetResponseStream());
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    var statusCode = ((HttpWebResponse)webException.Response).StatusCode;
                    
                    var stripeError = new StripeError();

                    if(webRequest.RequestUri.ToString().Contains("oauth"))
                        stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()));
                    else
                        stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()), "error");

                    throw new StripeException(statusCode, stripeError, stripeError.Message);
                }

                throw;
            }
        }

        private static string ReadStream(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public static string PostMultipartFormString(string url, Dictionary<string, string> postData,
         FileStream fileToUpload,
         string fileMimeType,
         string fileFormKey,
         string apiKey = null)
        {
            var wr = GetWebRequest(url, "POST", apiKey);

            return ExecuteMultipartFormPostRequest((HttpWebRequest)wr, postData, fileToUpload, fileMimeType, fileFormKey, apiKey);
        }

        internal static string ExecuteMultipartFormPostRequest(
          HttpWebRequest webRequest,
          Dictionary<string, string> postData,
          FileStream fileToUpload,
          string fileMimeType,
          string fileFormKey, string apiKey = null)
        {
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.KeepAlive = true;

            //Creates a multipart/form-data boundary.
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");

            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
            Stream requestStream = webRequest.GetRequestStream();
            postData.WriteMultipartFormData(requestStream, boundary);
            if (fileToUpload != null)
            {
                fileToUpload.WriteMultipartFormData(requestStream, boundary, fileMimeType, fileFormKey);
            }
            byte[] endBytes = Encoding.UTF8.GetBytes("--" + boundary + "--");
            requestStream.Write(endBytes, 0, endBytes.Length);
            requestStream.Close();

            try
            {
                using (WebResponse response = webRequest.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                };
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    var statusCode = ((HttpWebResponse)webException.Response).StatusCode;

                    var stripeError = new StripeError();

                    if (webRequest.RequestUri.ToString().Contains("oauth"))
                        stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()));
                    else
                        stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()), "error");

                    throw new StripeException(statusCode, stripeError, stripeError.Message);
                }

                throw;
            }

        }
    }
}
