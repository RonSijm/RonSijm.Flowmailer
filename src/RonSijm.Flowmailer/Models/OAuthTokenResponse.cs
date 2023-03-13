namespace RonSijm.Flowmailer.Models;

public class OAuthTokenResponse
{
    [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
    public string AccessToken { get; set; }

    [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
    public string Scope { get; set; }

    [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
    public int ExpiresIn { get; set; }

    public DateTime Received { get; set; }

    public bool IsExpired()
    {
        if (Received.AddMinutes(ExpiresIn - 1) > DateTime.Now)
        {
            return false;
        }
           
        return true;
    }
}