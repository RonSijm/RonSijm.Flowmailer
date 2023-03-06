namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Filtered recipient address
/// </summary>
public class Filter
{
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
    public string AccountId { get; set; }
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string Address { get; set; }
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Date { get; set; }
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("expiresOn", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime ExpiresOn { get; set; }
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("messageReturn", NullValueHandling = NullValueHandling.Ignore)]
    public MessageReturn MessageReturn { get; set; }
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    /// <summary>
    /// Filtered recipient address
    /// </summary>
    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string Reason { get; set; }
}