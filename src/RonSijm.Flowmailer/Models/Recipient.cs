namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Statistics for a single recipient
/// </summary>
public class Recipient
{
    /// <summary>
    /// Statistics for a single recipient
    /// </summary>
    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string Address { get; set; }
    /// <summary>
    /// Statistics for a single recipient
    /// </summary>
    [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
    public Filter[] Filters { get; set; }
    /// <summary>
    /// Statistics for a single recipient
    /// </summary>
    [JsonProperty("messageSummary", NullValueHandling = NullValueHandling.Ignore)]
    public MessageSummary MessageSummary { get; set; }
}