// By Casey Watson
// http://www.caseywatson.com/

using System;
using System.Configuration;

namespace Prowl
{
    public class ProwlClientConfiguration : ConfigurationSection
    {
        private const int API_KEYCHAIN_MAX_LENGTH = 204;
        private const int APPLICATION_NAME_MAX_LENGTH = 256;

        private const string API_KEYCHAIN_CFG_PROP_NAME = "apiKeychain";
        private const string APPLICATION_NAME_CFG_PROP_NAME = "applicationName";
        private const string BASE_URL_CFG_PROP_NAME = "baseUrl";
        private const string DEFAULT_BASE_URL = @"https://prowl.weks.net/publicapi/";

        private const string EX_MSG_API_KEYCHAIN_EXCEEDS_MAX_LENGTH =
            "Provided Prowl API keychain exceeds the maximum allowed length [{0}]; unable to proceed.";

        private const string EX_MSG_API_KEYCHAIN_NOT_PROVIDED = 
            "Prowl API keychain not provided; unable to proceed.";

        private const string EX_MSG_APPLICATION_NAME_EXCEEDS_MAX_LENGTH =
            "Provided Prowl application name exceeds the maximum allowed length [{0}]; unable to proceed.";

        private const string EX_MSG_APPLICATION_NAME_NOT_PROVIDED =
            "Prowl application name not provided; unable to proceed.";

        private const string EX_MSG_BASE_URL_IS_INVALID =
            "Provided Prowl API base URL is invalid; unable to proceed.";

        private const string EX_MSG_BASE_URL_NOT_PROVIDED =
            "Prowl API base URL not provided; unable to proceed.";

        private const string PROVIDER_KEY_CFG_PROP_NAME = "providerKey";

        public void Validate()
        {
            if (String.IsNullOrEmpty(ApiKeychain))
                throw new InvalidOperationException(EX_MSG_API_KEYCHAIN_NOT_PROVIDED);

            if (ApiKeychain.Length > API_KEYCHAIN_MAX_LENGTH)
                throw new InvalidOperationException(String.Format(EX_MSG_API_KEYCHAIN_EXCEEDS_MAX_LENGTH, API_KEYCHAIN_MAX_LENGTH));

            if (String.IsNullOrEmpty(ApplicationName))
                throw new InvalidOperationException(EX_MSG_APPLICATION_NAME_NOT_PROVIDED);

            if (ApplicationName.Length > APPLICATION_NAME_MAX_LENGTH)
                throw new InvalidOperationException(String.Format(EX_MSG_APPLICATION_NAME_EXCEEDS_MAX_LENGTH, APPLICATION_NAME_MAX_LENGTH));

            if (String.IsNullOrEmpty(BaseUrl))
                throw new InvalidOperationException(EX_MSG_BASE_URL_NOT_PROVIDED);

            var tempUri = default(Uri);

            if (!(Uri.TryCreate(BaseUrl, UriKind.Absolute, out tempUri)))
                throw new InvalidOperationException(EX_MSG_BASE_URL_IS_INVALID);
        }

        [ConfigurationProperty(API_KEYCHAIN_CFG_PROP_NAME, IsRequired = true)]
        public string ApiKeychain
        {
            get { return this[API_KEYCHAIN_CFG_PROP_NAME] as string; }
            set { this[API_KEYCHAIN_CFG_PROP_NAME] = value; }
        }

        [ConfigurationProperty(APPLICATION_NAME_CFG_PROP_NAME, IsRequired = true)]
        public string ApplicationName
        {
            get { return this[APPLICATION_NAME_CFG_PROP_NAME] as string; }
            set { this[APPLICATION_NAME_CFG_PROP_NAME] = value; }
        }

        [ConfigurationProperty(BASE_URL_CFG_PROP_NAME, DefaultValue = DEFAULT_BASE_URL)]
        public string BaseUrl
        {
            get { return this[BASE_URL_CFG_PROP_NAME] as string; }
            set { this[BASE_URL_CFG_PROP_NAME] = value; }
        }

        [ConfigurationProperty(PROVIDER_KEY_CFG_PROP_NAME)]
        public string ProviderKey
        {
            get { return this[PROVIDER_KEY_CFG_PROP_NAME] as string; }
            set { this[PROVIDER_KEY_CFG_PROP_NAME] = value; }
        }
    }
}
