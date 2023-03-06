using RonSijm.Flowmailer.Helpers;
using RonSijm.Flowmailer.Models;

namespace RonSijm.Flowmailer;

public partial class FlowMailerClient
{
    private OAuthTokenResponse _oauthTokenResponse;
        
    /// <summary>
    /// This call is used to request an access token using the client id and secret provided by flowmailer.
    /// </summary>
    private async Task<OAuthTokenResponse> OauthToken(CancellationToken cancellationToken = default)
    {
        var requestDictionary = new Dictionary<string, string>
        {
            { "client_id", _clientId },
            { "client_secret", _clientSecret },
            { "grant_type", "client_credentials" },
            { "scope", "api" }
        };

        using var client = _clientFactory.CreateClient();
        var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://login.flowmailer.net/oauth/token")
        {
            Content = new FormUrlEncodedContent(requestDictionary)
        };

        var sendResult = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<OAuthTokenResponse>(sendResult);

        _oauthTokenResponse = parseResult;
        _oauthTokenResponse.Received = DateTime.Now;

        return _oauthTokenResponse;
    }
}