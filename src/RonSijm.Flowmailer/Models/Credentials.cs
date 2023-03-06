namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Source system credentials
/// </summary>
public class Credentials
{
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("allowedAddresses", NullValueHandling = NullValueHandling.Ignore)]
    public string[] AllowedAddresses { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("allowedSenders", NullValueHandling = NullValueHandling.Ignore)]
    public string[] AllowedSenders { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("contactInfo", NullValueHandling = NullValueHandling.Ignore)]
    public string ContactInfo { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("inboundDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string InboundDomain { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("inboundRecipients", NullValueHandling = NullValueHandling.Ignore)]
    public InboundRecipient[] InboundRecipients { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
    public string Password { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
    public string Protocol { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceId { get; set; }
    /// <summary>
    /// Source system credentials
    /// </summary>
    [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
    public string Username { get; set; }
}