using System;
using System.Configuration;

namespace KS.Fiks.Maskinporten.Client.IntegrationTests
{
    public class DevServerConstants : ITestEnvironmentConstants
    {
        public string Scheme => "https";

        public int Port => 443;

        public string IdPortenCertFile => "secret-auth.p12";

        public string IdPortenCertPass => Environment.GetEnvironmentVariable("MASKINPORTEN_CERT_PWD")
                                          ?? throw new ConfigurationErrorsException("MASKINPORTEN_CERT_PWD environment variable not set");

        public string MaskinportenTokenEndpoint => @"https://test.maskinporten.no/token";

        public string MaskinportenAudience => @"https://test.maskinporten.no/";

        public string MaskinportenIssuer => @"77c0a0ba-d20d-424c-b5dd-f1c63da07fc4";

        public int MaskinportenNumberOfSecondsLeftBeforeExpire => 10;

        public string IntegrasjonId => "1d9a81ed-b1d4-46c2-bc35-6c331298d38a";

        public string IntegrasjonPassword => "A6_.z{gAt0ldfzuo5{P%0L2#%n#-jrtIb%&qzeW^gw2NOUH}F0";

        public string Host => "api.fiks.dev.ks.no";

        public string DefaultAccount => "a504eb17-212f-4295-9b94-53167ea8f143";

        public string Path => "/fiks-io/katalog/api/v1";

        public string AccountId => "a504eb17-212f-4295-9b94-53167ea8f143";

        public string OrganizationId => "3ba20d52-490d-497a-af6a-5d10577cd2fd";

        public string AmqpHost => "ksjenkins.usrv.ubergenkom.no";

        public int AmqpPort => 5671;
    }
}