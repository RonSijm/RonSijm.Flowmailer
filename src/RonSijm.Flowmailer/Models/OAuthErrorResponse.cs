namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Fields
/// </summary>
public class OAuthErrorResponse
{
    /// <summary>
    /// Fields
    /// </summary>
    [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
    public string AccessToken { get; set; }
    /// <summary>
    /// Fields
    /// </summary>
    [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
    public int ExpiresIn { get; set; }
    /// <summary>
    /// Fields
    /// </summary>
    [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
    public string Scope { get; set; }
    /// <summary>
    /// Fields
    /// </summary>
    [JsonProperty("token_type", NullValueHandling = NullValueHandling.Ignore)]
    public string TokenType { get; set; }
}