namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Sender identities are used to rewrite sender information.
/// </summary>
public class SenderIdentity
{
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("accountFallback", NullValueHandling = NullValueHandling.Ignore)]
    public bool AccountFallback { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("dkimKeys", NullValueHandling = NullValueHandling.Ignore)]
    public DkimKey[] DkimKeys { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("returnPathDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string ReturnPathDomain { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("selectionType", NullValueHandling = NullValueHandling.Ignore)]
    public string SelectionType { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("selectionValue", NullValueHandling = NullValueHandling.Ignore)]
    public string SelectionValue { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("senderEmail", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderEmail { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("senderName", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderName { get; set; }
    /// <summary>
    /// Sender identities are used to rewrite sender information.
    /// </summary>
    [JsonProperty("webDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string WebDomain { get; set; }
}