using System;

namespace KS.Fiks.Maskinporten.Client.IntegrationTests;

public class DevServerConstants : ITestEnvironmentConstants
{
    private readonly string _idPortenCertFile;
    private readonly string _idPortenCertPass;

    public DevServerConstants()
    {
        _idPortenCertFile = Environment.GetEnvironmentVariable("MASKINPORTEN_CERT");
        _idPortenCertPass = Environment.GetEnvironmentVariable("MASKINPORTEN_CERT_PWD");

        ValidateEnvironmentVariables();
    }

    private void ValidateEnvironmentVariables()
    {
        if (string.IsNullOrEmpty(_idPortenCertFile))
        {
            throw new InvalidOperationException("Miljøvariabelen 'MASKINPORTEN_CERT' er ikke satt");
        }

        if (string.IsNullOrEmpty(_idPortenCertPass))
        {
            throw new InvalidOperationException("Miljøvariabelen 'MASKINPORTEN_CERT_PWD' er ikke satt");
        }
    }

    public string IdPortenCertFile => _idPortenCertFile;

    public string IdPortenCertPass => _idPortenCertPass;

    public string MaskinportenTokenEndpoint => @"https://test.maskinporten.no/token";

    public string MaskinportenAudience => @"https://test.maskinporten.no/";

    public string MaskinportenIssuer => @"77c0a0ba-d20d-424c-b5dd-f1c63da07fc4";

    public int MaskinportenNumberOfSecondsLeftBeforeExpire => 10;
}