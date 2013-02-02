// By Casey Watson
// http://www.caseywatson.com/

using System;
using System.Configuration;
using System.Net;
using System.Text;
using System.Web;

namespace Prowl
{
    public class ProwlClient
    {
        private const string CLIENT_CONFIG_SECTION_NAME = "prowlClient";

        private const string EX_MSG_CLIENT_CONFIG_SECTION_NOT_FOUND =
            "Prowl client configuration section [{0}] not found; unable to proceed.";

        private const string POST_NOTIFICATION_BASE_METHOD = 
            "add?apikey={0}&application={1}&description={2}&event={3}&priority={4}";

        private const string POST_NOTIFICATION_PROVIDER_PARAMETER = "&provider={0}";
        private const string REQUEST_CONTENT_TYPE = "application/x-www-form-urlencoded";
        private const string REQUEST_METHOD_TYPE = "POST";

        private ProwlClientConfiguration _clientCfg;

        public ProwlClient() : this(null) { }

        public ProwlClient(ProwlClientConfiguration clientCfg_)
        {
            if (clientCfg_ == null)
            {
                var cfgSection = ConfigurationManager.GetSection(CLIENT_CONFIG_SECTION_NAME);

                if (cfgSection == null || !(cfgSection is ProwlClientConfiguration))
                    throw new InvalidOperationException(String.Format(EX_MSG_CLIENT_CONFIG_SECTION_NOT_FOUND, CLIENT_CONFIG_SECTION_NAME));

                clientCfg_ = (cfgSection as ProwlClientConfiguration);
            }

            _clientCfg = clientCfg_;
            _clientCfg.Validate();
        }

        public void PostNotification(ProwlNotification notification_)
        {
            notification_.Validate();

            var updateRequest = 
                HttpWebRequest.Create(BuildNotificationRequestUrl(notification_)) as HttpWebRequest;

            updateRequest.ContentLength = 0;
            updateRequest.ContentType = REQUEST_CONTENT_TYPE;
            updateRequest.Method = REQUEST_METHOD_TYPE;

            var postResponse = default(WebResponse);

            try
            {
                postResponse = updateRequest.GetResponse();
            }
            finally
            {
                if (postResponse != null)
                    postResponse.Close();
            }
        }

        private string BuildNotificationRequestUrl(ProwlNotification notification_)
        {
            if (!(_clientCfg.BaseUrl.EndsWith("/"))) _clientCfg.BaseUrl += "/";

            var prowlUrlSb = new StringBuilder(_clientCfg.BaseUrl);

            prowlUrlSb.AppendFormat(
                POST_NOTIFICATION_BASE_METHOD,
                HttpUtility.UrlEncode(_clientCfg.ApiKeychain),
                HttpUtility.UrlEncode(_clientCfg.ApplicationName),
                HttpUtility.UrlEncode(notification_.Description),
                HttpUtility.UrlEncode(notification_.Event),
                ((sbyte)(notification_.Priority)));

            if (!String.IsNullOrEmpty(_clientCfg.ProviderKey))
                prowlUrlSb.AppendFormat(
                    POST_NOTIFICATION_PROVIDER_PARAMETER,
                    HttpUtility.UrlEncode(_clientCfg.ProviderKey));

            return prowlUrlSb.ToString();
        }
    }
}
