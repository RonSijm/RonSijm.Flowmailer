namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Spotler API credentials
/// </summary>
public class MailPlusAPICredentials
{
    /// <summary>
    /// Spotler API credentials
    /// </summary>
    [JsonProperty("consumerKey", NullValueHandling = NullValueHandling.Ignore)]
    public string ConsumerKey { get; set; }
    /// <summary>
    /// Spotler API credentials
    /// </summary>
    [JsonProperty("consumerSecret", NullValueHandling = NullValueHandling.Ignore)]
    public string ConsumerSecret { get; set; }
}